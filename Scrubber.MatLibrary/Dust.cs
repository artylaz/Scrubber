using System;
using System.Collections.Generic;
using System.Text;

namespace Scrubber.MatLibrary
{
    public class Dust
    {
        public string Name { get; set; }
        public double KoefB { get; set; }
        public double KoefE { get; set; }


        public List<Dust> TipPili
        {
            get
            {
                return new List<Dust>()
                {
                    new Dust {Name = "Конвертерная", KoefB = 0.0988, KoefE = 0.4663},
                    new Dust {Name = "Ваграночная", KoefB = 0.01355, KoefE = 0.621},
                    new Dust { Name = "Мартеновская (обычная)", KoefB = 0.01915, KoefE = 0.5688 },
                    new Dust { Name = "Колошниковая пыль доменных печей", KoefB = 0.00661, KoefE = 0.891},
                    new Dust { Name = "Пыль известковых печей", KoefB = 0.00065, KoefE = 1.0529 },
                    new Dust { Name = "Пыль печей для плавки латуни", KoefB = 0.0234, KoefE = 0.5317},
                    new Dust { Name = "Щелочной аэрозоль из известковых печей", KoefB = 5.53E-05, KoefE = 1.2295 },
                    new Dust { Name = "Аэрозоль сульфата меди", KoefB = 0.000214, KoefE = 0.0679 },
                    new Dust { Name = "Пыль мартенов с дутьем, обогащенным О2", KoefB = 1.565E-06, KoefE = 1.619 },
                    new Dust { Name = "Пыль мартенов с воздушным дутьем", KoefB = 1.74E-06, KoefE = 1.594 },
                    new Dust { Name = "Пыль доменных печей", KoefB = 0.1925, KoefE = 1.594 },
                    new Dust { Name = "Пыль закрытых электропечей при выплавке ферросилиции", KoefB = 2.42E-05, KoefE = 1.26 },
                    new Dust { Name = "Пыль закрытых электропечей при выплавке силикомарганца", KoefB = 0.0069, KoefE = 0.67 },
                    new Dust { Name = "Пыль коалинового производства", KoefB = 0.000234, KoefE = 1.115 },
                    new Dust { Name = "Туман фосфорной кислоты", KoefB = 0.0134, KoefE = 0.6312 },
                    new Dust { Name = "Пыль при производстве целюлозы", KoefB = 0.0004, KoefE = 1.05 },
                    new Dust { Name = "Пыль производства черного щелока при увлажненных газах", KoefB = 0.00132, KoefE = 0.861 },
                    new Dust { Name = "Пыль производства черного щелока при сухих газах", KoefB = 0.00093, KoefE = 0.861 },
                    new Dust { Name = "Частицы поташа из МГД-установок", KoefB = 0.016, KoefE = 0.554 },
                    new Dust { Name = "Сажа при электрокрекинге метана", KoefB = 1E-05, KoefE = 1.36 }
                };
            }
        }
    }
}
