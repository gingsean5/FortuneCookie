'Sean Gingerich
'RCET0265
'Fall 2020
'Say My Name Again
'https://github.com/gingsean5/FortuneCookie
Module FortuneCookie

    Sub Main()
        Dim Rando As Integer
        Dim CountRando(5) As Integer
        Randomize()

        Rando = CInt(Int((6 * Rnd())))
        'Rando = 2

        Select Case Rando

            Case 0
                Console.WriteLine("Your work will be important in the search for new life")

            Case 1
                Console.WriteLine("Stay away from large bodies of water in the near future. It's looking for you")

            Case 2
                Console.WriteLine("The FitnessGram PACER Test is a multistage aerobic capacity test that progressively gets more difficult as it continues.
The test is used to measure a student's aerobic capacity as part of the FitnessGram assessment. 
Students run back and forth as many times as they can, each lap signaled by a beep sound.
The test get progressively faster as it continues until the student reaches their max lap score.
The PACER Test score is combined in the FitnessGram software with scores for muscular strength, endurance, flexibility
and body composition to determine whether a student is in the Healthy Fitness Zone or the Needs Improvement Zone.")

            Case 3
                Console.WriteLine("Watch out for a man in a Dr. Pepper t-shirt and white converse shoes")

            Case 4
                Console.WriteLine("Bananas are an excellent start to your day. Eat one every day next week or you will regret it")

            Case 5
                Console.WriteLine("The year of your birth in the chinese calendar will be important information in the coming days")


        End Select


        Console.Read()
    End Sub

End Module
