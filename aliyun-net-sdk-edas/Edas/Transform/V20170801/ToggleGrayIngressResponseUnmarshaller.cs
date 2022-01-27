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
    public class ToggleGrayIngressResponseUnmarshaller
    {
        public static ToggleGrayIngressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ToggleGrayIngressResponse toggleGrayIngressResponse = new ToggleGrayIngressResponse();

			toggleGrayIngressResponse.HttpResponse = _ctx.HttpResponse;
			toggleGrayIngressResponse.RequestId = _ctx.StringValue("ToggleGrayIngress.RequestId");
			toggleGrayIngressResponse.Code = _ctx.IntegerValue("ToggleGrayIngress.Code");
			toggleGrayIngressResponse.Message = _ctx.IntegerValue("ToggleGrayIngress.Message");

			ToggleGrayIngressResponse.ToggleGrayIngress_Data data = new ToggleGrayIngressResponse.ToggleGrayIngress_Data();
			data.PointcutId = _ctx.LongValue("ToggleGrayIngress.Data.PointcutId");
			data.RegionId = _ctx.StringValue("ToggleGrayIngress.Data.RegionId");

			ToggleGrayIngressResponse.ToggleGrayIngress_Data.ToggleGrayIngress_Spec spec = new ToggleGrayIngressResponse.ToggleGrayIngress_Data.ToggleGrayIngress_Spec();
			spec.ShowName = _ctx.StringValue("ToggleGrayIngress.Data.Spec.ShowName");
			spec.Tag = _ctx.StringValue("ToggleGrayIngress.Data.Spec.Tag");
			spec.Enable = _ctx.BooleanValue("ToggleGrayIngress.Data.Spec.Enable");
			spec.Selector = _ctx.StringValue("ToggleGrayIngress.Data.Spec.Selector");

			List<ToggleGrayIngressResponse.ToggleGrayIngress_Data.ToggleGrayIngress_Spec.ToggleGrayIngress_ScopesItem> spec_scopes = new List<ToggleGrayIngressResponse.ToggleGrayIngress_Data.ToggleGrayIngress_Spec.ToggleGrayIngress_ScopesItem>();
			for (int i = 0; i < _ctx.Length("ToggleGrayIngress.Data.Spec.Scopes.Length"); i++) {
				ToggleGrayIngressResponse.ToggleGrayIngress_Data.ToggleGrayIngress_Spec.ToggleGrayIngress_ScopesItem scopesItem = new ToggleGrayIngressResponse.ToggleGrayIngress_Data.ToggleGrayIngress_Spec.ToggleGrayIngress_ScopesItem();
				scopesItem.Id = _ctx.LongValue("ToggleGrayIngress.Data.Spec.Scopes["+ i +"].Id");
				scopesItem.Key = _ctx.StringValue("ToggleGrayIngress.Data.Spec.Scopes["+ i +"].Key");
				scopesItem._Value = _ctx.StringValue("ToggleGrayIngress.Data.Spec.Scopes["+ i +"].Value");

				ToggleGrayIngressResponse.ToggleGrayIngress_Data.ToggleGrayIngress_Spec.ToggleGrayIngress_ScopesItem.ToggleGrayIngress_ValueFrom valueFrom = new ToggleGrayIngressResponse.ToggleGrayIngress_Data.ToggleGrayIngress_Spec.ToggleGrayIngress_ScopesItem.ToggleGrayIngress_ValueFrom();
				valueFrom.RefName = _ctx.StringValue("ToggleGrayIngress.Data.Spec.Scopes["+ i +"].ValueFrom.RefName");
				valueFrom.RefValue = _ctx.StringValue("ToggleGrayIngress.Data.Spec.Scopes["+ i +"].ValueFrom.RefValue");
				scopesItem.ValueFrom = valueFrom;

				spec_scopes.Add(scopesItem);
			}
			spec.Scopes = spec_scopes;
			data.Spec = spec;
			toggleGrayIngressResponse.Data = data;
        
			return toggleGrayIngressResponse;
        }
    }
}
