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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class ListCheckInstanceResultResponseUnmarshaller
    {
        public static ListCheckInstanceResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCheckInstanceResultResponse listCheckInstanceResultResponse = new ListCheckInstanceResultResponse();

			listCheckInstanceResultResponse.HttpResponse = _ctx.HttpResponse;
			listCheckInstanceResultResponse.RequestId = _ctx.StringValue("ListCheckInstanceResult.RequestId");

			List<Dictionary<string, string>> listCheckInstanceResultResponse_checks = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ListCheckInstanceResult.Checks.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ListCheckInstanceResult.Checks["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					listCheckInstanceResultResponse_checks.Add(tmp);
				}
			}
			listCheckInstanceResultResponse.Checks = listCheckInstanceResultResponse_checks;

			ListCheckInstanceResultResponse.ListCheckInstanceResult_PageInfo pageInfo = new ListCheckInstanceResultResponse.ListCheckInstanceResult_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListCheckInstanceResult.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListCheckInstanceResult.PageInfo.PageSize");
			pageInfo.NextToken = _ctx.StringValue("ListCheckInstanceResult.PageInfo.NextToken");
			pageInfo.MaxResults = _ctx.IntegerValue("ListCheckInstanceResult.PageInfo.MaxResults");
			pageInfo.TotalCount = _ctx.IntegerValue("ListCheckInstanceResult.PageInfo.TotalCount");
			pageInfo.Count = _ctx.StringValue("ListCheckInstanceResult.PageInfo.Count");
			listCheckInstanceResultResponse.PageInfo = pageInfo;

			List<ListCheckInstanceResultResponse.ListCheckInstanceResult_BasicDataItem> listCheckInstanceResultResponse_basicData = new List<ListCheckInstanceResultResponse.ListCheckInstanceResult_BasicDataItem>();
			for (int i = 0; i < _ctx.Length("ListCheckInstanceResult.BasicData.Length"); i++) {
				ListCheckInstanceResultResponse.ListCheckInstanceResult_BasicDataItem basicDataItem = new ListCheckInstanceResultResponse.ListCheckInstanceResult_BasicDataItem();
				basicDataItem.Id = _ctx.LongValue("ListCheckInstanceResult.BasicData["+ i +"].Id");
				basicDataItem.Status = _ctx.StringValue("ListCheckInstanceResult.BasicData["+ i +"].Status");
				basicDataItem.RegionId = _ctx.StringValue("ListCheckInstanceResult.BasicData["+ i +"].RegionId");
				basicDataItem.InstanceId = _ctx.StringValue("ListCheckInstanceResult.BasicData["+ i +"].InstanceId");
				basicDataItem.InstanceName = _ctx.StringValue("ListCheckInstanceResult.BasicData["+ i +"].InstanceName");

				listCheckInstanceResultResponse_basicData.Add(basicDataItem);
			}
			listCheckInstanceResultResponse.BasicData = listCheckInstanceResultResponse_basicData;

			List<ListCheckInstanceResultResponse.ListCheckInstanceResult_ColumnsItem> listCheckInstanceResultResponse_columns = new List<ListCheckInstanceResultResponse.ListCheckInstanceResult_ColumnsItem>();
			for (int i = 0; i < _ctx.Length("ListCheckInstanceResult.Columns.Length"); i++) {
				ListCheckInstanceResultResponse.ListCheckInstanceResult_ColumnsItem columnsItem = new ListCheckInstanceResultResponse.ListCheckInstanceResult_ColumnsItem();
				columnsItem.Type = _ctx.StringValue("ListCheckInstanceResult.Columns["+ i +"].Type");
				columnsItem.Key = _ctx.StringValue("ListCheckInstanceResult.Columns["+ i +"].Key");
				columnsItem.ShowName = _ctx.StringValue("ListCheckInstanceResult.Columns["+ i +"].ShowName");
				columnsItem.Search = _ctx.BooleanValue("ListCheckInstanceResult.Columns["+ i +"].Search");
				columnsItem.SearchKey = _ctx.StringValue("ListCheckInstanceResult.Columns["+ i +"].SearchKey");

				List<ListCheckInstanceResultResponse.ListCheckInstanceResult_ColumnsItem.ListCheckInstanceResult_GridsItem> columnsItem_grids = new List<ListCheckInstanceResultResponse.ListCheckInstanceResult_ColumnsItem.ListCheckInstanceResult_GridsItem>();
				for (int j = 0; j < _ctx.Length("ListCheckInstanceResult.Columns["+ i +"].Grids.Length"); j++) {
					ListCheckInstanceResultResponse.ListCheckInstanceResult_ColumnsItem.ListCheckInstanceResult_GridsItem gridsItem = new ListCheckInstanceResultResponse.ListCheckInstanceResult_ColumnsItem.ListCheckInstanceResult_GridsItem();
					gridsItem.Type = _ctx.StringValue("ListCheckInstanceResult.Columns["+ i +"].Grids["+ j +"].Type");
					gridsItem.Key = _ctx.StringValue("ListCheckInstanceResult.Columns["+ i +"].Grids["+ j +"].Key");
					gridsItem.ShowName = _ctx.StringValue("ListCheckInstanceResult.Columns["+ i +"].Grids["+ j +"].ShowName");

					columnsItem_grids.Add(gridsItem);
				}
				columnsItem.Grids = columnsItem_grids;

				listCheckInstanceResultResponse_columns.Add(columnsItem);
			}
			listCheckInstanceResultResponse.Columns = listCheckInstanceResultResponse_columns;
        
			return listCheckInstanceResultResponse;
        }
    }
}
