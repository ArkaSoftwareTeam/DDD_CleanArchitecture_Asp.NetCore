﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hesabdari.Infrastructure.Data.SQLCommands.Extentions
{
    public static class RowVersionShadowProperty
    {
        public static readonly string RowVersion = nameof(RowVersion);

        public static void AddRowVersionShadowProperty<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : class
            => builder.Property<byte[]>(RowVersion).IsRowVersion();
    }
}
