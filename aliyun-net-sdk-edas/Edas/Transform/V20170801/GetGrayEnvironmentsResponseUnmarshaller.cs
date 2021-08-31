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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetGrayEnvironmentsResponseUnmarshaller
    {
        public static GetGrayEnvironmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetGrayEnvironmentsResponse getGrayEnvironmentsResponse = new GetGrayEnvironmentsResponse();

			getGrayEnvironmentsResponse.HttpResponse = _ctx.HttpResponse;
			getGrayEnvironmentsResponse.RequestId = _ctx.StringValue("GetGrayEnvironments.RequestId");
			getGrayEnvironmentsResponse.Code = _ctx.IntegerValue("GetGrayEnvironments.Code");
			getGrayEnvironmentsResponse.Message = _ctx.StringValue("GetGrayEnvironments.Message");

			List<GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList> getGrayEnvironmentsResponse_data = new List<GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList>();
			for (int i = 0; i < _ctx.Length("GetGrayEnvironments.Data.Length"); i++) {
				GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList envList = new GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList();
				envList.AccountId = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].AccountId");
				envList.PointcutId = _ctx.LongValue("GetGrayEnvironments.Data["+ i +"].PointcutId");
				envList.RegionId = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].RegionId");
				envList.TenantId = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].TenantId");

				GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Metadata metadata = new GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Metadata();
				metadata.Labels = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Metadata.Labels");
				metadata.Annotations = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Metadata.Annotations");
				metadata.Name = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Metadata.Name");
				metadata._Namespace = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Metadata.Namespace");
				envList.Metadata = metadata;

				GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Spec spec = new GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Spec();
				spec.Enable = _ctx.BooleanValue("GetGrayEnvironments.Data["+ i +"].Spec.Enable");
				spec.ShowName = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Spec.ShowName");
				spec.Single = _ctx.BooleanValue("GetGrayEnvironments.Data["+ i +"].Spec.Single");
				spec.Tag = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Spec.Tag");
				spec.Selector = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Spec.Selector");

				List<GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Spec.GetGrayEnvironments_ScopesItem> spec_scopes = new List<GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Spec.GetGrayEnvironments_ScopesItem>();
				for (int j = 0; j < _ctx.Length("GetGrayEnvironments.Data["+ i +"].Spec.Scopes.Length"); j++) {
					GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Spec.GetGrayEnvironments_ScopesItem scopesItem = new GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Spec.GetGrayEnvironments_ScopesItem();
					scopesItem.Id = _ctx.LongValue("GetGrayEnvironments.Data["+ i +"].Spec.Scopes["+ j +"].Id");
					scopesItem.Key = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Spec.Scopes["+ j +"].Key");
					scopesItem._Value = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Spec.Scopes["+ j +"].Value");
					scopesItem.Extra = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Spec.Scopes["+ j +"].Extra");

					GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Spec.GetGrayEnvironments_ScopesItem.GetGrayEnvironments_ValueFrom valueFrom = new GetGrayEnvironmentsResponse.GetGrayEnvironments_EnvList.GetGrayEnvironments_Spec.GetGrayEnvironments_ScopesItem.GetGrayEnvironments_ValueFrom();
					valueFrom.RefName = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Spec.Scopes["+ j +"].ValueFrom.RefName");
					valueFrom.RefValue = _ctx.StringValue("GetGrayEnvironments.Data["+ i +"].Spec.Scopes["+ j +"].ValueFrom.RefValue");
					scopesItem.ValueFrom = valueFrom;

					spec_scopes.Add(scopesItem);
				}
				spec.Scopes = spec_scopes;
				envList.Spec = spec;

				getGrayEnvironmentsResponse_data.Add(envList);
			}
			getGrayEnvironmentsResponse.Data = getGrayEnvironmentsResponse_data;
        
			return getGrayEnvironmentsResponse;
        }
    }
}
