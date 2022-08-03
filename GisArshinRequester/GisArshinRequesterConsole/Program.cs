using GisArshinRequesterLib;

var si = new InformationRegisterAboutSiVerificationResults();

var res = await si.GetByType(orgName: "25913-08", year: 2020, skip: 1, take: 10, SortType.Asc);




foreach (var item in res)
{
    Console.WriteLine();
    Console.WriteLine($"Идентификатор элемента: {item.Id}");
    Console.WriteLine($"Наименование организации-поверителя: {item.OrgName}");
    Console.WriteLine($"Регистрационный номер типа СИ: {item.RegistrationNumber}");
    Console.WriteLine($"Наименование типа СИ: {item.TypeName}");
    Console.WriteLine($"Обозначение типа СИ: {item.TypeNotation}");
    Console.WriteLine($"Модификация СИ: {item.Modification}");
    Console.WriteLine($"Заводской/серийный номер/буквенноцифровое обозначение: {item.Number}");
    Console.WriteLine($"Дата поверки: {item.VerificationDate}");
    Console.WriteLine($"Действительна до: {item.ValidDate}");
    Console.WriteLine($"Номер свидетельства/извещения/выписки: {item.DocumentNumber}");
    Console.WriteLine($"Пригодность: {item.Applicability}");
    Console.WriteLine();
}