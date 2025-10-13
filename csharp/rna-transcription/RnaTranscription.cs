using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] rnaList = nucleotide.ToCharArray();
        for (int i = 0; i < rnaList.Length; i++)
        {
            switch (rnaList[i])
            {
                case 'G':
                    rnaList[i] = 'C';
                    break;
                case 'C':
                    rnaList[i] = 'G';
                    break;
                case 'T':
                    rnaList[i] = 'A';
                    break;
                case 'A':
                    rnaList[i] = 'U';
                    break;
            }
        }
        String rnaString = new String(rnaList);
        return rnaString;
    }
}
