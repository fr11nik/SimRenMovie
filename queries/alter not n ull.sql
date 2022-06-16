/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
use SimRenMovie

--alter table filmsdata 
--alter column FilmName  nvarchar(90) not null
--UPDATE [filmsdata] SET [FilmName]= 'f' WHERE [FilmName] IS NULL
--alter table filmsdata  add constraint UQ_filmsdata unique (FilmName)
ALTER TABLE [purchases] ALTER COLUMN [idFilm] int NOT NULL