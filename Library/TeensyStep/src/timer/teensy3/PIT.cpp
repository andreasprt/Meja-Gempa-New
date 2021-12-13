#include "PIT.h"
 
 #include "../TF_Handler.h"

namespace
{
    TF_Handler* Handler[4];

    template<int n>
    void dispatchFunc()
    {      
        Handler[n]->stepTimerISR();     
    }

    constexpr void(*dispatcher[])(void) =
    {
        dispatchFunc<0>,
        dispatchFunc<1>,
        dispatchFunc<2>,
        dispatchFunc<3>
    };

    void dummyISR(void) {}
}

bool PIT::begin(TF_Handler* handler)
{
    if (!timer.begin(dummyISR, 1E6)) return false;  // load semua channel

    setupChannel();                                 // scanning reserved timer
    const int channelNr = channel - KINETISK_PIT_CHANNELS; // ditemukan timer kosong
    Handler[channelNr] = handler;                // simpan IRQ handler
	timer.priority(32);							// pilih timer 32 bit
    timer.begin(dispatcher[channelNr], 1E6);     // gunakan ISR untuk memecah 32 bit timer menjadi 5 micro													
    stop();        		                            // stop 

    return true;
}

void PIT::setupChannel()
{
    IRQ_NUMBER_t number = (IRQ_NUMBER_t)timer;
    switch (number)
    {
    case IRQ_PIT_CH0:
        channel = KINETISK_PIT_CHANNELS + 0;
        break;
    case IRQ_PIT_CH1:
        channel = KINETISK_PIT_CHANNELS + 1;
        break;
    case IRQ_PIT_CH2:
        channel = KINETISK_PIT_CHANNELS + 2;
        break;
    case IRQ_PIT_CH3:
        channel = KINETISK_PIT_CHANNELS + 3;
        break;
    default:
        channel = nullptr;
        break;
    }
}