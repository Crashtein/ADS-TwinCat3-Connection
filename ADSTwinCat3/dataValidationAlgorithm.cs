using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSTwinCat3
{


    class dataValidationAlgorithm
    {

        private List<int> tabState = null;
        private int numberOfCheksStates = 3;

        public dataValidationAlgorithm(List<int> setTabState, int setNumberOfCheksStates)
        {
            tabState = setTabState;
            numberOfCheksStates = setNumberOfCheksStates;
        }

        public bool camel(List<int> pastStates, int currentState)//czy wielbłąd Buhahahaha
        {

            //              private List<int> tabState = null;
            //      private List<string> limitSwitches = null;//private string[] limitSwitches = { "X5", "X6", "X8", "X7" };
            //    private List<int> pastStates;
            bool errorSwitches = true;
            for (int i = 0; i < tabState.Count; i++)
            {
                //Console.WriteLine("i:   "+i);

                
                if (false == errorSwitches)
                {
                    break;
                }
                if (tabState[i] == currentState)
                {
                    if (pastStates.Count != 0)
                    {
                        Console.WriteLine("i:   " + i);
                        Console.WriteLine("tabState[i]: " + tabState[i]);
                        Console.WriteLine("currentState: " + currentState);

                        int iterPastStates = pastStates.Count - 1;
                        int iterFromEnd = 0;
                        int iterComp = 0;//the same what iterComparison but calculate from zero
                        for (int iterComparisons = numberOfCheksStates - 2; iterComparisons >= 0; iterComparisons--)
                        {



                            if (iterPastStates >= 0)//check if we have enough elements in work fistory - pastStates
                            {

                                if (i - 1 - iterComp >= 0)// check if tabState ends and we have to start from the end of our tabStates, i-current state, i-1 - last state
                                {
                                    Console.WriteLine("pastStates[iterPastStates]:  " + pastStates[iterPastStates]);
                                    Console.WriteLine("tabState[tabState.Count - iterFromEnd]:  " + tabState[i - 1 - iterComp]);
                                    if (pastStates[iterPastStates] != tabState[i - 1 - iterComp])
                                    {
                                        errorSwitches = true;
                                        break;
                                    }
                                    else
                                    {
                                        errorSwitches = false;
                                    }

                                }
                                else
                                {
                                    iterFromEnd++;
                                    Console.WriteLine("pastStates[iterPastStates]:  " + pastStates[iterPastStates]);
                                    Console.WriteLine("tabState[tabState.Count - iterFromEnd]:  " + tabState[tabState.Count - iterFromEnd]);

                                    if (pastStates[iterPastStates] != tabState[tabState.Count - iterFromEnd])
                                    {
                                        errorSwitches = true;
                                        break;
                                    }
                                    else
                                    {
                                        errorSwitches = false;
                                    }

                                }
                            }
                            iterComp = iterComp + 1;
                            iterPastStates--;
                        }
                    }
                    else
                    {
                        errorSwitches = false;
                        return errorSwitches;
                    }

                  
                }
            }
            return errorSwitches;
        }

    }

    
}
