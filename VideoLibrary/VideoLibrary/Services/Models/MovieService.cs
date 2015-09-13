using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary.Models;

namespace VideoLibrary.Services.Models
{
    public class VideoService
    {
        private IGenericRepository _repo;

        public VideoService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<ApplicationUser> ListUsers()
        {

            return _repo.Query<ApplicationUser>().ToList();

        }

        public IList<ActorDTO> ListOfActors()
        {
            var dtoList = new List<ActorDTO>();
            foreach(Actor a in _repo.Query<Actor>().ToList())
            {
                dtoList.Add(Mapper.Map<ActorDTO>(a));
            }

            return dtoList;

        }

        public IList<DirectorDTO> ListOfDirectors()
        {
            var dtoList = new List<DirectorDTO>();
            foreach (Director a in _repo.Query<Director>().ToList())
            {
                dtoList.Add(Mapper.Map<DirectorDTO>(a));
            }

            return dtoList;
        }

        public ActorDTO FindActor(string lastName)
        {
            var targetActor = _repo.Query<Actor>().FirstOrDefault(t => t.LastName == lastName);
            ActorDTO actorDTO = Mapper.Map<ActorDTO>(targetActor);

            return actorDTO;

        }

    }
}
