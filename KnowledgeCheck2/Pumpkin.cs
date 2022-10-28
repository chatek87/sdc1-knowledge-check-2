namespace KnowledgeCheck2;

class Pumpkin : HalloweenDecoration
{
    public bool IsCarved { get; set; }

    public void Boo()
    {
        Console.WriteLine(@"

                    /}
             _,---~-LJ,-~-._
          ,-^  '   '   '    ^:,
         :   .    '      '     :
        :     /| .   /\   '     :
       :   . //|    // \   '     :
       :     `~` /| `^~`    '     ;
       :  '     //|         '    :
       :   \-_  `~`    ,    '    :
       ;  . \.\_,--,_;^/   ,    :
        :    ^-_!^!__/^   ,    :
         :,  ,  .        ,    :   
           ^--_____     .   ;`
                   `^''----`
");
    }
}
