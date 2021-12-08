namespace N4S_Player
{
    internal class Song_List
    {
        public static void StringSepr(string[] s, Details[] dtl, int n)
        {
            for (int i = 0; i < n; i++)
            {
                dtl[i].pathdetails = s[i];
                
                string empt = "";
                char[] ch = s[i].ToCharArray();
                int len = ch.Length;
                int l = 0;
                for (int j = len-1; j >= 0; j--)
                {
                    if (ch[j] == '\\')
                        break;
                    else
                    {
                        l++;
                        empt += ch[j];
                    }
                }
                dtl[i].name = "";
                for (int j = l - 1; j >= 0; j--)
                {
                    dtl[i].name += empt[j];
                }                
            }
        }
    }
}
