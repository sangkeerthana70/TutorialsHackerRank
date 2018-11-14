       static int GetMaxPopulation(int [] population, int [] location, int [] cloudLoc, int [] cloudRange)
        {
            /* Step 1: Calculate wingspan of each cloud and store in a list called wingSpan
                 wing span: (location - range) to (location + range)
               Step 2: Iterate through town locations, if a town is not within wingspan of any cloud, 
                 add population of that town to variable sunnyPopulation. This represents sunnyPopulation
                 before removing any cloud. A helper method called IsTownUnderCloud determines 
                 if a given town is under any cloud
              Step 3: Determine population under each cloud and identify the cloud that covers maximum
                 population. Removing this cloud will bring that population under Sun. Add that number to 
                 sunnyPopulation and return
            */

            int start,end,loc,range, sunnyPopulation = 0,maxPopulationUnderACloud = 0;
            List<int[]> wingSpan = new List<int[]>();

            for (var i = 0; i < cloudLoc.Length; i++)
            {
                loc = cloudLoc[i];
                range = cloudRange[i];
                start =  loc - range;
                end = loc + range;
                wingSpan.Add(new int[] { start, end, loc });
            }

            // Calculate population already in Sunny towns
            for(var i = 0; i < location.Length; i ++)
            {
                bool result = IsTownUnderCloud(location[i], wingSpan);
                if (result == false)
                {
                    sunnyPopulation += population[i];
                }
            }

            // Calculate population under each cloud
            int cloudPop;
            foreach (int[] ws in wingSpan)
            {
                cloudPop = 0;
                for (var i = 0; i < location.Length; i++)
                {
                    if ((location[i] >= ws[0]) && (location[i] <= ws[1]))
                    {
                        cloudPop += population[i];
                    }
                }

                if (cloudPop > maxPopulationUnderACloud)
                {
                    maxPopulationUnderACloud = cloudPop;
                }

            }

            return sunnyPopulation + maxPopulationUnderACloud;
        }

        static Boolean IsTownUnderCloud(int location, List<int[]> wingSpan)
        {
            foreach (int[] ws in wingSpan)
            {
                //Console.WriteLine("start: " + ws[0] + " end: " + ws[1]);
                if ((location >= ws[0]) && (location <= ws[1]))
                {
                    return true;
                }

            }    
            return false;
        }
    }