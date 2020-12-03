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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QuerySolutionProjectResponseUnmarshaller
    {
        public static QuerySolutionProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySolutionProjectResponse querySolutionProjectResponse = new QuerySolutionProjectResponse();

			querySolutionProjectResponse.HttpResponse = _ctx.HttpResponse;
			querySolutionProjectResponse.RequestId = _ctx.StringValue("QuerySolutionProject.RequestId");
			querySolutionProjectResponse.Success = _ctx.BooleanValue("QuerySolutionProject.Success");
			querySolutionProjectResponse.Code = _ctx.StringValue("QuerySolutionProject.Code");
			querySolutionProjectResponse.ErrorMessage = _ctx.StringValue("QuerySolutionProject.ErrorMessage");

			QuerySolutionProjectResponse.QuerySolutionProject_Data data = new QuerySolutionProjectResponse.QuerySolutionProject_Data();
			data.Total = _ctx.IntegerValue("QuerySolutionProject.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySolutionProject.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySolutionProject.Data.PageSize");

			List<QuerySolutionProjectResponse.QuerySolutionProject_Data.QuerySolutionProject_Items> data_list = new List<QuerySolutionProjectResponse.QuerySolutionProject_Data.QuerySolutionProject_Items>();
			for (int i = 0; i < _ctx.Length("QuerySolutionProject.Data.List.Length"); i++) {
				QuerySolutionProjectResponse.QuerySolutionProject_Data.QuerySolutionProject_Items items = new QuerySolutionProjectResponse.QuerySolutionProject_Data.QuerySolutionProject_Items();
				items.GmtCreate = _ctx.LongValue("QuerySolutionProject.Data.List["+ i +"].GmtCreate");
				items.Name = _ctx.StringValue("QuerySolutionProject.Data.List["+ i +"].Name");
				items.Code = _ctx.StringValue("QuerySolutionProject.Data.List["+ i +"].Code");
				items.Status = _ctx.StringValue("QuerySolutionProject.Data.List["+ i +"].Status");
				items.Description = _ctx.StringValue("QuerySolutionProject.Data.List["+ i +"].Description");

				QuerySolutionProjectResponse.QuerySolutionProject_Data.QuerySolutionProject_Items.QuerySolutionProject_ExtMap extMap = new QuerySolutionProjectResponse.QuerySolutionProject_Data.QuerySolutionProject_Items.QuerySolutionProject_ExtMap();
				extMap.ProductKey = _ctx.StringValue("QuerySolutionProject.Data.List["+ i +"].ExtMap.ProductKey");
				items.ExtMap = extMap;

				data_list.Add(items);
			}
			data.List = data_list;
			querySolutionProjectResponse.Data = data;
        
			return querySolutionProjectResponse;
        }
    }
}
