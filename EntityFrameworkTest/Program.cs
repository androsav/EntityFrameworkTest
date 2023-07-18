using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			entityTestEntities1 _core = new entityTestEntities1();

			#region Add items to DB

			//PhoneType _phoneType1 = new PhoneType()
			//{
			//	PhoneType_Id = Guid.NewGuid(),
			//	PhoneType_Name = "Мобильный"
			//};

			//PhoneType _phoneType2 = new PhoneType()
			//{
			//	PhoneType_Id = Guid.NewGuid(),
			//	PhoneType_Name = "Рабочий"
			//};
			//_core.PhoneType.Add(_phoneType1);
			//_core.PhoneType.Add(_phoneType2);

			//EmailType _emailType1 = new EmailType()
			//{
			//	EmailType_Id = Guid.NewGuid(),
			//	EmailType_Name = "Личная"
			//};

			//EmailType _emailType2 = new EmailType()
			//{
			//	EmailType_Id = Guid.NewGuid(),
			//	EmailType_Name = "Рабочая"
			//};
			//_core.EmailType.Add(_emailType1);
			//_core.EmailType.Add(_emailType2);
			//_core.SaveChanges();

			//===================================


			//List<EmpTask> empTasks = new List<EmpTask>
			//{
			//	new EmpTask()
			//	{
			//	Task_Id = Guid.NewGuid(),
			//	Task_Name = "Вайп",
			//	Task_DeadLine = "Завтра",
			//	Task_PrevCompleted = false,
			//	Task_Completed = false
			//	},
			//	new EmpTask()
			//	{
			//	Task_Id = Guid.NewGuid(),
			//	Task_Name = "Поесть",
			//	Task_DeadLine = "Сегодня",
			//	Task_PrevCompleted = false,
			//	Task_Completed = false
			//	},
			//	new EmpTask()
			//	{
			//	Task_Id = Guid.NewGuid(),
			//	Task_Name = "Перенести вайп",
			//	Task_DeadLine = "Завтра",
			//	Task_PrevCompleted = false,
			//	Task_Completed = false
			//	},
			//	new EmpTask()
			//	{
			//	Task_Id = Guid.NewGuid(),
			//	Task_Name = "Добавить баги",
			//	Task_DeadLine = "Сегодня",
			//	Task_PrevCompleted = false,
			//	Task_Completed = false
			//	}
			//};

			//Employee _emp1 = new Employee()
			//{
			//	Employee_Id = Guid.NewGuid(),
			//	Employee_FIO = "Комар Нуян Бикитович",
			//	EmpTask = { empTasks[0], empTasks[1], empTasks[3] }
			//};
			//_core.Employee.Add(_emp1);

			//List<EmailType> e = _core.EmailType.ToList();
			//EmailType ew = e.Where(t => t.EmailType_Name.Equals("Рабочая")).First();
			//EmailType ep = e.Where(t => t.EmailType_Name.Equals("Личная")).First();

			//List<PhoneType> p = _core.PhoneType.ToList();
			//PhoneType pw = p.Where(t => t.PhoneType_Name.Equals("Рабочий")).First();
			//PhoneType pp = p.Where(t => t.PhoneType_Name.Equals("Мобильный")).First();

			//Email _email1 = new Email()
			//{
			//	Email_Id = Guid.NewGuid(),
			//	Email_Name = "bikitovich_nuyan@tarkov.game",
			//	EmailType = ew,
			//	Employee = _emp1
			//};
			//Email _email2 = new Email()
			//{
			//	Email_Id = Guid.NewGuid(),
			//	Email_Name = "sbeu_komar@reserv.map",
			//	EmailType = ep,
			//	Employee = _emp1
			//};
			//_core.Email.Add(_email1);
			//_core.Email.Add(_email2);

			//Phone _phone1 = new Phone()
			//{
			//	Phone_Id = Guid.NewGuid(),
			//	Phone_Number = "8924433343",
			//	PhoneType = pw,
			//	Employee = _emp1
			//};
			//Phone _phone2 = new Phone()
			//{
			//	Phone_Id = Guid.NewGuid(),
			//	Phone_Number = "89124564222",
			//	PhoneType = pp,
			//	Employee = _emp1
			//};
			//_core.Phone.Add(_phone1);
			//_core.Phone.Add(_phone2);
			//_core.SaveChanges();



			//Employee _emp2 = new Employee()
			//{
			//	Employee_Id = Guid.NewGuid(),
			//	Employee_FIO = "Бешеный Влад Никитич",
			//	EmpTask = {  empTasks[2], empTasks[3] }
			//};
			//_core.Employee.Add(_emp2);

			//List<EmailType> ee = _core.EmailType.ToList();
			//EmailType eww = ee.Where(t => t.EmailType_Name.Equals("Рабочая")).First();
			//EmailType epp = ee.Where(t => t.EmailType_Name.Equals("Личная")).First();

			//List<PhoneType> p2 = _core.PhoneType.ToList();
			//PhoneType pww = p2.Where(t => t.PhoneType_Name.Equals("Рабочий")).First();
			//PhoneType ppp = p2.Where(t => t.PhoneType_Name.Equals("Мобильный")).First();

			//Email _email11 = new Email()
			//{
			//	Email_Id = Guid.NewGuid(),
			//	Email_Name = "besheny_vlad@tar.norv",
			//	EmailType = epp,
			//	Employee = _emp2
			//};
			//Email _email22 = new Email()
			//{
			//	Email_Id = Guid.NewGuid(),
			//	Email_Name = "vladislav_nikitych@mail.ru",
			//	EmailType = eww,
			//	Employee = _emp2
			//};
			//_core.Email.Add(_email11);
			//_core.Email.Add(_email22);

			//Phone _phone11 = new Phone()
			//{
			//	Phone_Id = Guid.NewGuid(),
			//	Phone_Number = "+79423333441",
			//	PhoneType = pww,
			//	Employee = _emp2
			//};
			//Phone _phone22 = new Phone()
			//{
			//	Phone_Id = Guid.NewGuid(),
			//	Phone_Number = "+79245642127",
			//	PhoneType = ppp,
			//	Employee = _emp2
			//};
			//_core.Phone.Add(_phone11);
			//_core.Phone.Add(_phone22);

			//_core.SaveChanges();
			#endregion

			bool isCycleRunning = true;
			while (isCycleRunning)
			{
				Console.WriteLine("\nВведите номер дейтсвия:\n 1)Вывести сотрудников (Select) \n 2)Insert \n 3)Update \n 4)Delete");
				switch (Console.ReadLine())
				{
					case "1":
						#region Select

						var a = _core.Employee
							.Join(_core.Email,
							e => e.Employee_Id,
							m => m.Employee_Id, (emp, em) => new { emp, em })
							.Join(_core.Phone,
							e => e.em.Employee_Id,
							p => p.Employee_Id, (e, p) => new
							{
								Employee = e.emp,
								Email = e.em,
								Phone = p
							})
							.Distinct();

						List<Employee> employees = new List<Employee>();
						List<Email> emails = new List<Email>();
						List<Phone> phones = new List<Phone>();
						foreach (var e in a)
						{
							employees.Add(e.Employee);
							emails.Add(e.Email);
							phones.Add(e.Phone);
						}

						var result = _core.Employee
						.SelectMany(e => e.EmpTask, (empl, task) => new { empl, task });

						foreach (var emp in employees.Distinct())
						{
							Console.WriteLine($"\nИнформация о сотруднике {emp.Employee_FIO}:");

							foreach (var em in emails.Distinct().Where(e => e.Employee_Id == emp.Employee_Id))
								Console.WriteLine(em.EmailType.EmailType_Name + " почта " + em.Email_Name);

							foreach (var p in phones.Distinct().Where(p => p.Employee_Id == emp.Employee_Id))
								Console.WriteLine(p.PhoneType.PhoneType_Name + " телефон " + p.Phone_Number);

							Console.WriteLine($"\nНазначенные задачи:");
							foreach (var t in result.Where(g => g.empl.Employee_Id == emp.Employee_Id))

								Console.WriteLine("Название задачи: " + t.task.Task_Name + ", статус: " + t.task.Task_Completed + ", дедлайн: " + t.task.Task_DeadLine);
						}
						#endregion
						break;
					case "2":
						#region Insert

						EmpTask tsk = new EmpTask()
						{
							Task_Id = Guid.NewGuid(),
							Task_Name = "Добавить ивент",
							Task_DeadLine = DateTime.Today.AddDays(1).ToString(),
							Task_PrevCompleted = false,
							Task_Completed = false
						};

						var aa = _core.Employee.First();
						aa.EmpTask.Add(tsk);
						_core.SaveChanges();

						#endregion
						break;
					case "3":
						#region Update

						var ttt = _core.EmpTask.Where(b => b.Task_Name == "Добавить ивент").ToList();
						EmpTask aaa = ttt.First();
						aaa.Task_DeadLine = DateTime.Today.ToString();
						_core.SaveChanges();

						#endregion
						break;
					case "4":
						#region Delete
						var ttttt = _core.EmpTask.Where(b => b.Task_Name == "Добавить ивент").ToList();
						EmpTask aaaa = ttttt.First();
						_core.EmpTask.Remove(aaaa);
						_core.SaveChanges();
						#endregion
						break;
					default:
						isCycleRunning = false;
						break;
				}
			}
			
			Console.ReadLine();
		}
	}
}
