/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ExecuteScriptResponseUnmarshaller
    {
        public static ExecuteScriptResponse Unmarshall(UnmarshallerContext context)
        {
			ExecuteScriptResponse executeScriptResponse = new ExecuteScriptResponse();

			executeScriptResponse.HttpResponse = context.HttpResponse;
			executeScriptResponse.RequestId = context.StringValue("ExecuteScript.RequestId");
			executeScriptResponse.Success = context.BooleanValue("ExecuteScript.Success");
			executeScriptResponse.ErrorMessage = context.StringValue("ExecuteScript.ErrorMessage");
			executeScriptResponse.ErrorCode = context.StringValue("ExecuteScript.ErrorCode");

			List<ExecuteScriptResponse.ExecuteScript_Result> executeScriptResponse_results = new List<ExecuteScriptResponse.ExecuteScript_Result>();
			for (int i = 0; i < context.Length("ExecuteScript.Results.Length"); i++) {
				ExecuteScriptResponse.ExecuteScript_Result result = new ExecuteScriptResponse.ExecuteScript_Result();
				result.RowCount = context.LongValue("ExecuteScript.Results["+ i +"].RowCount");
				result.Success = context.BooleanValue("ExecuteScript.Results["+ i +"].Success");
				result.Message = context.StringValue("ExecuteScript.Results["+ i +"].Message");

				List<string> result_columnNames = new List<string>();
				for (int j = 0; j < context.Length("ExecuteScript.Results["+ i +"].ColumnNames.Length"); j++) {
					result_columnNames.Add(context.StringValue("ExecuteScript.Results["+ i +"].ColumnNames["+ j +"]"));
				}
				result.ColumnNames = result_columnNames;

				List<Dictionary<string, string>> result_rows = new List<Dictionary<string, string>>();
				for (int j = 0; j < context.Length("ExecuteScript.Results["+ i +"].Rows.Length"); j++) {
					Dictionary<string, string> tmp = new Dictionary<string, string>() { };
					foreach (var _item in context.ResponseDictionary){
						string prefix = "ExecuteScript.Results["+ i +"].Rows["+ j +"].";
						if (_item.Key.IndexOf(prefix) == 0){
							tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
						}
					}
					if (tmp.Count > 0){
						result_rows.Add(tmp);
					}
				}
				result.Rows = result_rows;

				executeScriptResponse_results.Add(result);
			}
			executeScriptResponse.Results = executeScriptResponse_results;
        
			return executeScriptResponse;
        }
    }
}
