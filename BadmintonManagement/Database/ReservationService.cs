using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Database
{
    public class ReservationService
    {
        private ModelBadmintonManage _modelBadmintonManage = new ModelBadmintonManage();
        private List<COURT> _courts = new ModelBadmintonManage().COURT.ToList();
        private List<BRANCH> _branchs = new ModelBadmintonManage().BRANCH.ToList();
        private List<RESERVATION> _reservation = new ModelBadmintonManage().RESERVATION.ToList();
        private List<RF_DETAIL> _rfdetail = new ModelBadmintonManage().RF_DETAIL.ToList();



    }
}
