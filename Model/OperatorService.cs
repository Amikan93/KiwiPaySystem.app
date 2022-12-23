using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCreatePay.app.Model
{
    public class OperatorService
    {
        Model2 db = new Model2();

        public List<Operators> GetOperators()
        {
            List<Operators> operators = new List<Operators>();
            operators = db.Operators.ToList();
            return operators;
        }

        public bool AddOperator(Operators operators)
        {
            try
            {
                db.Operators.Add(operators);
                db.SaveChanges();
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }
    }
}
