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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class GetFeatureViewResponseUnmarshaller
    {
        public static GetFeatureViewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFeatureViewResponse getFeatureViewResponse = new GetFeatureViewResponse();

			getFeatureViewResponse.HttpResponse = _ctx.HttpResponse;
			getFeatureViewResponse.RequestId = _ctx.StringValue("GetFeatureView.RequestId");
			getFeatureViewResponse.ProjectId = _ctx.StringValue("GetFeatureView.ProjectId");
			getFeatureViewResponse.ProjectName = _ctx.StringValue("GetFeatureView.ProjectName");
			getFeatureViewResponse.FeatureEntityName = _ctx.StringValue("GetFeatureView.FeatureEntityName");
			getFeatureViewResponse.Name = _ctx.StringValue("GetFeatureView.Name");
			getFeatureViewResponse.Owner = _ctx.StringValue("GetFeatureView.Owner");
			getFeatureViewResponse.Type = _ctx.StringValue("GetFeatureView.Type");
			getFeatureViewResponse.GmtCreateTime = _ctx.StringValue("GetFeatureView.GmtCreateTime");
			getFeatureViewResponse.GmtModifiedTime = _ctx.StringValue("GetFeatureView.GmtModifiedTime");
			getFeatureViewResponse.FeatureEntityId = _ctx.StringValue("GetFeatureView.FeatureEntityId");
			getFeatureViewResponse.JoinId = _ctx.StringValue("GetFeatureView.JoinId");
			getFeatureViewResponse.WriteMethod = _ctx.StringValue("GetFeatureView.WriteMethod");
			getFeatureViewResponse.RegisterTable = _ctx.StringValue("GetFeatureView.RegisterTable");
			getFeatureViewResponse.RegisterDatasourceId = _ctx.StringValue("GetFeatureView.RegisterDatasourceId");
			getFeatureViewResponse.RegisterDatasourceName = _ctx.StringValue("GetFeatureView.RegisterDatasourceName");
			getFeatureViewResponse.WriteToFeatureDB = _ctx.BooleanValue("GetFeatureView.WriteToFeatureDB");
			getFeatureViewResponse.SyncOnlineTable = _ctx.BooleanValue("GetFeatureView.SyncOnlineTable");
			getFeatureViewResponse.TTL = _ctx.IntegerValue("GetFeatureView.TTL");
			getFeatureViewResponse.Config = _ctx.StringValue("GetFeatureView.Config");
			getFeatureViewResponse.GmtSyncTime = _ctx.StringValue("GetFeatureView.GmtSyncTime");
			getFeatureViewResponse.LastSyncConfig = _ctx.StringValue("GetFeatureView.LastSyncConfig");
			getFeatureViewResponse.PublishTableScript = _ctx.StringValue("GetFeatureView.PublishTableScript");
			getFeatureViewResponse.MockTableName = _ctx.StringValue("GetFeatureView.MockTableName");

			List<string> getFeatureViewResponse_tags = new List<string>();
			for (int i = 0; i < _ctx.Length("GetFeatureView.Tags.Length"); i++) {
				getFeatureViewResponse_tags.Add(_ctx.StringValue("GetFeatureView.Tags["+ i +"]"));
			}
			getFeatureViewResponse.Tags = getFeatureViewResponse_tags;

			List<GetFeatureViewResponse.GetFeatureView_FieldsItem> getFeatureViewResponse_fields = new List<GetFeatureViewResponse.GetFeatureView_FieldsItem>();
			for (int i = 0; i < _ctx.Length("GetFeatureView.Fields.Length"); i++) {
				GetFeatureViewResponse.GetFeatureView_FieldsItem fieldsItem = new GetFeatureViewResponse.GetFeatureView_FieldsItem();
				fieldsItem.Name = _ctx.StringValue("GetFeatureView.Fields["+ i +"].Name");
				fieldsItem.Type = _ctx.StringValue("GetFeatureView.Fields["+ i +"].Type");

				List<string> fieldsItem_attributes = new List<string>();
				for (int j = 0; j < _ctx.Length("GetFeatureView.Fields["+ i +"].Attributes.Length"); j++) {
					fieldsItem_attributes.Add(_ctx.StringValue("GetFeatureView.Fields["+ i +"].Attributes["+ j +"]"));
				}
				fieldsItem.Attributes = fieldsItem_attributes;

				getFeatureViewResponse_fields.Add(fieldsItem);
			}
			getFeatureViewResponse.Fields = getFeatureViewResponse_fields;
        
			return getFeatureViewResponse;
        }
    }
}
