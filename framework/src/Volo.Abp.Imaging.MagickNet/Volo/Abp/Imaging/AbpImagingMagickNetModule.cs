﻿using Volo.Abp.Modularity;

namespace Volo.Abp.Imaging;

[DependsOn(typeof(AbpImagingAbstractionsModule))]
public class AbpImagingMagickNetModule : AbpModule
{
}