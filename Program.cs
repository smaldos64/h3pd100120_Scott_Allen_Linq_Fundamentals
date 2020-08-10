//#define Video3_The_Power_Of_IEnumerable
//#define Video3_Creating_An_Extension_Method
//#define Video3_Understanding_Lambda_Expression
//#define Video_3_Using_Func_And_Action_Types
//#define Video3_Query_Syntax_Versus_Method_Syntax

//#define Video4_Creating_A_Custom_Filter_Operation
//#define Video4_Taking_Advantage_Of_Deferred_Execution
//#define Video4_Avoiding_Pittfalls_Of_Deferred_Execution
//#define Video4_Exceptions_And_Deferred_Scott_Allen_Linq_Fundamentals
//#define Video4_All_About_Streaming_Operators
//#define Video4_Querying_Infinity

//#define Video5_Implementing_A_File_Processor
//#define Video5_Finding_The_Most_Fuel_Efficient_Car
//#define Video5_Filtering_With_Where_And_First
//#define Video5_Quantifying_Data_With_Any_All
//#define Video5_Projecting_Data_With_Select
//#define Video5_Flattering_Data_With_SelectMany

//#define Video6_Joining_Data_With_Query_Syntax
//#define Video6_Joining_Data_With_Extension_Method_Syntax
//#define Video6_Creating_A_Join_With_A_Composition
//#define Video6_Grouping_Data
//#define Video6_Using_A_GroupJoin_For_Hierarchy
//#define Video6_Challenge_Answer_Group_By_Country
//#define Video6_Aggreating_Data
//#define Video6_Aggregation_With_Extended_Method

//#define Video8_Inserting_Data_Into_A_New_Database
//#define Video8_Writing_A_Basic_Query_With_Linq
#define Video8_Working_With_IQueryables_And_Expression_Trees

using Scott_Allen_Linq_Fundamentals.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

using Scott_Allen_Linq_Fundamentals.Video3;
using Scott_Allen_Linq_Fundamentals.Video4;
using Scott_Allen_Linq_Fundamentals.Video5;
using Scott_Allen_Linq_Fundamentals.Video6;
using Scott_Allen_Linq_Fundamentals.Video8;

namespace Scott_Allen_Linq_Fundamentals
{
    class Program
    {
        // IEnumerable<T> er den perfekte data type at anvende, når man skal "gemme" den egentlige kilde af data
        // List, Arry etc. 
        // Blandt andet derfor arbejder 99% af alle Linq features op imod IEnumerable.
        // Linq arbejder ved at bruge Extensions metoder !!!
        static void Main(string[] args)
        {
#if (Video3_The_Power_Of_IEnumerable)
            Video3_The_Power_Of_IEnumerable.Video3_The_Power_Of_IEnumerable_Start();
#endif

#if (Video3_Creating_An_Extension_Method)
            Video3_Creating_An_Extension_Method.Video3_Creating_An_Extension_Method_Start();
#endif

#if (Video3_Understanding_Lambda_Expression)
            Video3_Understanding_Lambda_Expression.Video3_Understanding_Lambda_Expression_Start();
#endif

#if Video_3_Using_Func_And_Action_Types
            Video3_Using_Func_And_Action_Types.Video_3_Using_Func_And_Action_Types_Start();
#endif

#if (Video3_Query_Syntax_Versus_Method_Syntax)
            Video3_Query_Syntax_Versus_Method_Syntax.Video3_Query_Syntax_Versus_Method_Syntax_Start();
#endif

#if (Video4_Creating_A_Custom_Filter_Operation)
            Video4_Creating_A_Custom_Filter_Operation.Video4_Creating_A_Custom_Filter_Operation_start();
#endif

#if (Video4_Taking_Advantage_Of_Deferred_Execution)
            Video4_Taking_Advantage_Of_Deferred_Execution.Video4_Taking_Advantage_Of_Deferred_Execution_Start();
#endif

#if (Video4_Avoiding_Pittfalls_Of_Deferred_Execution)
            Video4_Avoiding_Pittfalls_Of_Deferred_Execution.Video4_Avoiding_Pittfalls_Of_Deferred_Execution_Start();
#endif

#if (Video4_Exceptions_And_Deferred_Scott_Allen_Linq_Fundamentals)
            Video4_Exceptions_And_Deferred_Scott_Allen_Linq_Fundamentals.Video4_Exceptions_And_Deferred_Scott_Allen_Linq_Fundamentals_Start();
#endif

#if (Video4_All_About_Streaming_Operators)
            Video4_All_About_Streaming_Operators.Video4_All_About_Streaming_Operators_Start();
#endif

#if (Video4_Querying_Infinity)
            Video4_Querying_Infinity.Video4_Querying_Infinity_Start();
#endif

#if (Video5_Implementing_A_File_Processor)
            Video5_Implementing_A_File_Processor.Video5_Implementing_A_File_Processor_Start();
#endif

#if (Video5_Finding_The_Most_Fuel_Efficient_Car)
            Video5_Finding_The_Most_Fuel_Efficient_Car.Video5_Finding_The_Most_Fuel_Efficient_Car_Start();
#endif

#if (Video5_Filtering_With_Where_And_First)
            Video5_Filtering_With_Where_And_First.Video5_Filtering_With_Where_And_First_Start();
#endif

#if (Video5_Quantifying_Data_With_Any_All)
            Video5_Quantifying_Data_With_Any_All_Contains.Video5_Quantifying_Data_With_Any_All_Contains_Start();
#endif

#if (Video5_Projecting_Data_With_Select)
            Video5_Projecting_Data_With_Select.Video5_Projecting_Data_With_Select_Start();
#endif

#if (Video5_Flattering_Data_With_SelectMany)
            Video5_Flattering_Data_With_SelectMany.Video5_Flattering_Data_With_SelectMany_Start();
#endif


#if (Video6_Joining_Data_With_Query_Syntax)
            Video6_Joining_Data_With_Query_Syntax.Video6_Joining_Data_With_Query_Syntax_Start();
#endif

#if (Video6_Joining_Data_With_Extension_Method_Syntax)
            Video6_Joining_Data_With_Extension_Method_Syntax.Video6_Joining_Data_With_Extension_Method_Syntax_Start();
#endif

#if (Video6_Creating_A_Join_With_A_Composition)
            Video6_Creating_A_Join_With_A_Composition.Video6_Creating_A_Join_With_A_Composition_Start();
#endif

#if (Video6_Grouping_Data)
            Video6_Grouping_Data.Video6_Grouping_Data_Start();
#endif

#if (Video6_Using_A_GroupJoin_For_Hierarchy)
            Video6_Using_A_GroupJoin_For_Hierarchy.Video6_Using_A_GroupJoin_For_Hierarchy_Start();
#endif

#if (Video6_Challenge_Answer_Group_By_Country)
            Video6_Challenge_Answer_Group_By_Country.Video6_Challenge_Answer_Group_By_Country_start();
#endif

#if (Video6_Aggreating_Data)
            Video6_Aggreating_Data.Video6_Aggreating_Data_Start();
#endif

#if (Video6_Aggregation_With_Extended_Method)
            Video6_Aggregation_With_Extended_Method.Video6_Aggregation_With_Extended_Method_Start();
#endif

#if (Video8_Inserting_Data_Into_A_New_Database)
            Video8_Inserting_Data_Into_A_New_Database.Video8_Inserting_Data_Into_A_New_Database_Start();
#endif

#if (Video8_Writing_A_Basic_Query_With_Linq)
            Video8_Writing_A_Basic_Query_With_Linq.Video8_Writing_A_Basic_Query_With_Linq_Start();
#endif

#if (Video8_Working_With_IQueryables_And_Expression_Trees)
            Video8_Working_With_IQueryables_And_Expression_Trees.Video8_Working_With_IQueryables_And_Expression_Trees_Start();
#endif

            Console.ReadLine();    
        }
    }
}
  
