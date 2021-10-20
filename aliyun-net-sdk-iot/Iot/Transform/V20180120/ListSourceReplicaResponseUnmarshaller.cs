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
    public class ListSourceReplicaResponseUnmarshaller
    {
        public static ListSourceReplicaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSourceReplicaResponse listSourceReplicaResponse = new ListSourceReplicaResponse();

			listSourceReplicaResponse.HttpResponse = _ctx.HttpResponse;
			listSourceReplicaResponse.RequestId = _ctx.StringValue("ListSourceReplica.RequestId");
			listSourceReplicaResponse.Success = _ctx.BooleanValue("ListSourceReplica.Success");
			listSourceReplicaResponse.Code = _ctx.StringValue("ListSourceReplica.Code");
			listSourceReplicaResponse.ErrorMessage = _ctx.StringValue("ListSourceReplica.ErrorMessage");

			ListSourceReplicaResponse.ListSourceReplica_Data data = new ListSourceReplicaResponse.ListSourceReplica_Data();
			data.Total = _ctx.LongValue("ListSourceReplica.Data.Total");
			data.TotalPage = _ctx.LongValue("ListSourceReplica.Data.TotalPage");
			data.PageSize = _ctx.IntegerValue("ListSourceReplica.Data.PageSize");
			data.PageNo = _ctx.IntegerValue("ListSourceReplica.Data.PageNo");

			List<ListSourceReplicaResponse.ListSourceReplica_Data.ListSourceReplica_DataListItem> data_dataList = new List<ListSourceReplicaResponse.ListSourceReplica_Data.ListSourceReplica_DataListItem>();
			for (int i = 0; i < _ctx.Length("ListSourceReplica.Data.DataList.Length"); i++) {
				ListSourceReplicaResponse.ListSourceReplica_Data.ListSourceReplica_DataListItem dataListItem = new ListSourceReplicaResponse.ListSourceReplica_Data.ListSourceReplica_DataListItem();
				dataListItem.ReplicaUid = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].ReplicaUid");
				dataListItem.Name = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].Name");
				dataListItem.Code = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].Code");
				dataListItem.SourceUid = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].SourceUid");
				dataListItem.TableUid = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].TableUid");
				dataListItem.SourceType = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].SourceType");
				dataListItem.TimeCycle = _ctx.IntegerValue("ListSourceReplica.Data.DataList["+ i +"].TimeCycle");
				dataListItem.TimeUnit = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].TimeUnit");
				dataListItem.Region = _ctx.IntegerValue("ListSourceReplica.Data.DataList["+ i +"].Region");
				dataListItem.BeginLatest = _ctx.LongValue("ListSourceReplica.Data.DataList["+ i +"].BeginLatest");
				dataListItem.EndLatest = _ctx.LongValue("ListSourceReplica.Data.DataList["+ i +"].EndLatest");
				dataListItem.ExtraProperty = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].ExtraProperty");
				dataListItem.Status = _ctx.IntegerValue("ListSourceReplica.Data.DataList["+ i +"].Status");
				dataListItem.StorageSize = _ctx.LongValue("ListSourceReplica.Data.DataList["+ i +"].StorageSize");
				dataListItem.ProductCreateTime = _ctx.LongValue("ListSourceReplica.Data.DataList["+ i +"].ProductCreateTime");
				dataListItem.NodeType = _ctx.IntegerValue("ListSourceReplica.Data.DataList["+ i +"].NodeType");
				dataListItem.NeedTips = _ctx.BooleanValue("ListSourceReplica.Data.DataList["+ i +"].NeedTips");
				dataListItem.LongJobUid = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].LongJobUid");
				dataListItem.Desc = _ctx.StringValue("ListSourceReplica.Data.DataList["+ i +"].Desc");
				dataListItem.GmtCreate = _ctx.LongValue("ListSourceReplica.Data.DataList["+ i +"].GmtCreate");

				data_dataList.Add(dataListItem);
			}
			data.DataList = data_dataList;
			listSourceReplicaResponse.Data = data;
        
			return listSourceReplicaResponse;
        }
    }
}
