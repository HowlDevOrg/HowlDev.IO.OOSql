using BenchmarkDotNet.Running;
using HowlDev.IO.OOSql.Benchmarks;

var result = BenchmarkRunner.Run<FullQueryTest>();

Console.WriteLine(result.Reports.Length);

for (int i = 0; i < result.Reports.Length; i++) {
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine(result.Reports[i].BenchmarkCase.Descriptor.WorkloadMethod.Name);
    Console.WriteLine(result.Reports[i].ResultStatistics!.Mean);
    Console.WriteLine(result.Reports[i].Metrics["Allocated Memory"].Value);
}



