#define Video3_3_The_Power_Of_IEnumerable
#define Video3_4_Creating_An_Extension_Method
#define Video3_5_Understanding_Lambda_Expression
#define Video_3_6_Using_Func_And_Action_Types
#define Video3_7_Query_Syntax_Versus_Method_Syntax

#define Video4_2_Creating_A_Custom_Filter_Operation
#define Video4_3_Taking_Advantage_Of_Deferred_Execution
#define Video4_6_Avoiding_Pittfalls_Of_Deferred_Execution
#define Video4_7_Exceptions_And_Deferred_Queries
#define Video4_8_All_About_Streaming_Operators
#define Video4_9_Querying_Infinity

#define Video5_4_Implementing_A_File_Processor
#define Video5_5_Finding_The_Most_Fuel_Efficient_Car
#define Video5_6_Filtering_With_Where_And_First
#define Video5_7_Quantifying_Data_With_Any_All
#define Video5_8_Projecting_Data_With_Select
#define Video5_9_Flattering_Data_With_SelectMany

//#define Video6_3_Joining_Data_With_Query_Syntax
//#define Video6_4_Joining_Data_Using_Extension_Method_Syntax
//#define Video6_5_Creating_A_Join_With_A_Composition
//#define Video6_6_Grouping_Data
//#define Video6_7_Using_A_GroupJoin_For_Hierarchy
//#define Video6_8_Challenge_Answer_Group_By_Country
//#define Video6_9_Aggreating_Data
//#define Video6_10_Efficient_Aggregation_With_Extended_Method

//#define Video8_3_Inserting_Data_Into_A_New_Database
//#define Video8_4_Writing_A_Basic_Query_With_Linq
//#define Video8_5_Working_With_IQueryables_And_Expression_Trees
//#define Video8_6_Ceavats_And_Pitfalls_Of_Remote_LINQ
#define Video8_7_An_Advanced_LINQ_Query

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
#if (Video3_3_The_Power_Of_IEnumerable)
            Video3_3_The_Power_Of_IEnumerable.Video3_3_The_Power_Of_IEnumerable_Start();
#endif

#if (Video3_4_Creating_An_Extension_Method)
            Video3_4_Creating_An_Extension_Method.Video3_4_Creating_An_Extension_Method_Start();
#endif

#if (Video3_5_Understanding_Lambda_Expression)
            Video3_5_Understanding_Lambda_Expression.Video3_5_Understanding_Lambda_Expression_Start();
#endif

#if Video_3_6_Using_Func_And_Action_Types
            Video3_6_Using_Func_And_Action_Types.Video_3_6_Using_Func_And_Action_Types_Start();
#endif

#if (Video3_7_Query_Syntax_Versus_Method_Syntax)
            Video3_7_Query_Syntax_Versus_Method_Syntax.Video3_7_Query_Syntax_Versus_Method_Syntax_Start();
#endif

#if (Video4_2_Creating_A_Custom_Filter_Operation)
            Video4_2_Creating_A_Custom_Filter_Operation.Video4_2_Creating_A_Custom_Filter_Operation_start();
#endif

#if (Video4_3_Taking_Advantage_Of_Deferred_Execution)
            Video4_3_Taking_Advantage_Of_Deferred_Execution.Video4_3_Taking_Advantage_Of_Deferred_Execution_Start();
#endif

#if (Video4_6_Avoiding_Pittfalls_Of_Deferred_Execution)
            Video4_6_Avoiding_Pittfalls_Of_Deferred_Execution.Video4_6_Avoiding_Pittfalls_Of_Deferred_Execution_Start();
#endif

#if (Video4_7_Exceptions_And_Deferred_Queries)
            Video4_7_Exceptions_And_Deferred_Queries.Video4_7_Exceptions_And_Deferred_Queries_Start();
#endif

#if (Video4_8_All_About_Streaming_Operators)
            Video4_8_All_About_Streaming_Operators.Video4_8_All_About_Streaming_Operators_Start();
#endif

#if (Video4_9_Querying_Infinity)
            Video4_9_Querying_Infinity.Video4_9_Querying_Infinity_Start();
#endif

#if (Video5_4_Implementing_A_File_Processor)
            Video5_4_Implementing_A_File_Processor.Video5_4_Implementing_A_File_Processor_Start();
#endif

#if (Video5_5_Finding_The_Most_Fuel_Efficient_Car)
            Video5_5_Finding_The_Most_Fuel_Efficient_Car.Video5_5_Finding_The_Most_Fuel_Efficient_Car_Start();
#endif

#if (Video5_6_Filtering_With_Where_And_First)
            Video5_6_Filtering_With_Where_And_First.Video5_6_Filtering_With_Where_And_First_Start();
#endif

#if (Video5_7_Quantifying_Data_With_Any_All)
            Video5_7_Quantifying_Data_With_Any_All_Contains.Video5_7_Quantifying_Data_With_Any_All_Contains_Start();
#endif

#if (Video5_8_Projecting_Data_With_Select)
            Video5_8_Projecting_Data_With_Select.Video5_8_Projecting_Data_With_Select_Start();
#endif

#if (Video5_9_Flattering_Data_With_SelectMany)
            Video5_9_Flattering_Data_With_SelectMany.Video5_9_Flattering_Data_With_SelectMany_Start();
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

#if (Video8_Ceavats_And_Pitfalls_Of_Remote_LINQ)
            Video8_Ceavats_And_Pitfalls_Of_Remote_LINQ.Video8_Ceavats_And_Pitfalls_Of_Remote_LINQ_Start();
#endif

#if (Video8_An_Advanced_LINQ_Query)
            Video8_An_Advanced_LINQ_Query.Video8_An_Advanced_LINQ_Query_Start();
#endif

            Console.ReadLine();    
        }
    }
}
  
