using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


//MAPEAMENTO
namespace Api.Data.Mapping
{
    public class VideoMap : IEntityTypeConfiguration<VideosEntities>
    {
        //podemos criar os campos que acessarãoo banco para criar as tabelasno BD
        public void Configure(EntityTypeBuilder<VideosEntities> builder)
        {
            builder.ToTable("Videos");
            //key
            builder.HasKey(film => film.id);
            //campo name
            builder.Property(film => film.Name)
                   .HasMaxLength(100);


        }
    }
}
