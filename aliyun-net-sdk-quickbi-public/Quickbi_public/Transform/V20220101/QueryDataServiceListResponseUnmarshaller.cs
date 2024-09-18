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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryDataServiceListResponseUnmarshaller
    {
        public static QueryDataServiceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDataServiceListResponse queryDataServiceListResponse = new QueryDataServiceListResponse();

			queryDataServiceListResponse.HttpResponse = _ctx.HttpResponse;
			queryDataServiceListResponse.RequestId = _ctx.StringValue("QueryDataServiceList.RequestId");
			queryDataServiceListResponse.Success = _ctx.BooleanValue("QueryDataServiceList.Success");

			QueryDataServiceListResponse.QueryDataServiceList_Result result = new QueryDataServiceListResponse.QueryDataServiceList_Result();
			result.PageNum = _ctx.IntegerValue("QueryDataServiceList.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryDataServiceList.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("QueryDataServiceList.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("QueryDataServiceList.Result.TotalPages");

			List<QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel> result_data = new List<QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel>();
			for (int i = 0; i < _ctx.Length("QueryDataServiceList.Result.Data.Length"); i++) {
				QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel queryDataServiceModel = new QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel();
				queryDataServiceModel.CreatorId = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].CreatorId");
				queryDataServiceModel.CreatorName = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].CreatorName");
				queryDataServiceModel.CubeId = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].CubeId");
				queryDataServiceModel.CubeName = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].CubeName");
				queryDataServiceModel.Desc = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Desc");
				queryDataServiceModel.GmtCreate = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].GmtCreate");
				queryDataServiceModel.GmtModified = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].GmtModified");
				queryDataServiceModel.ModifierId = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].ModifierId");
				queryDataServiceModel.ModifierName = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].ModifierName");
				queryDataServiceModel.Name = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Name");
				queryDataServiceModel.OwnerId = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].OwnerId");
				queryDataServiceModel.OwnerName = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].OwnerName");
				queryDataServiceModel.Sid = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Sid");
				queryDataServiceModel.WorkspaceId = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].WorkspaceId");
				queryDataServiceModel.WorkspaceName = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].WorkspaceName");

				QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content content = new QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content();
				content.CubeId = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.CubeId");
				content.CubeName = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.CubeName");
				content.Detail = _ctx.BooleanValue("QueryDataServiceList.Result.Data["+ i +"].Content.Detail");

				QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content.QueryDataServiceList_Filter filter = new QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content.QueryDataServiceList_Filter();
				filter.LogicalOperator = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.Filter.LogicalOperator");
				filter.Type = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.Filter.Type");

				List<Dictionary<string, string>> filter_filters = new List<Dictionary<string, string>>();
				for (int j = 0; j < _ctx.Length("QueryDataServiceList.Result.Data["+ i +"].Content.Filter.Filters.Length"); j++) {
					Dictionary<string, string> tmp = new Dictionary<string, string>() { };
					foreach (var _item in _ctx.ResponseDictionary){
						string prefix = "QueryDataServiceList.Result.Data["+ i +"].Content.Filter.Filters["+ j +"].";
						if (_item.Key.IndexOf(prefix) == 0){
							tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
						}
					}
					if (tmp.Count > 0){
						filter_filters.Add(tmp);
					}
				}
				filter.Filters = filter_filters;
				content.Filter = filter;

				List<QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content.QueryDataServiceList_SelectFieldModel> content_returnFields = new List<QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content.QueryDataServiceList_SelectFieldModel>();
				for (int j = 0; j < _ctx.Length("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields.Length"); j++) {
					QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content.QueryDataServiceList_SelectFieldModel selectFieldModel = new QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content.QueryDataServiceList_SelectFieldModel();
					selectFieldModel.Aggregator = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Aggregator");
					selectFieldModel.Alias = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Alias");
					selectFieldModel.Desc = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Desc");
					selectFieldModel.Orderby = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Orderby");

					QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content.QueryDataServiceList_SelectFieldModel.QueryDataServiceList_Field field = new QueryDataServiceListResponse.QueryDataServiceList_Result.QueryDataServiceList_QueryDataServiceModel.QueryDataServiceList_Content.QueryDataServiceList_SelectFieldModel.QueryDataServiceList_Field();
					field.Caption = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Field.Caption");
					field.Column = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Field.Column");
					field.DataType = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Field.DataType");
					field.Fid = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Field.Fid");
					field.Granularity = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Field.Granularity");
					field.Name = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Field.Name");
					field.Type = _ctx.StringValue("QueryDataServiceList.Result.Data["+ i +"].Content.ReturnFields["+ j +"].Field.Type");
					selectFieldModel.Field = field;

					content_returnFields.Add(selectFieldModel);
				}
				content.ReturnFields = content_returnFields;
				queryDataServiceModel.Content = content;

				result_data.Add(queryDataServiceModel);
			}
			result.Data = result_data;
			queryDataServiceListResponse.Result = result;
        
			return queryDataServiceListResponse;
        }
    }
}
