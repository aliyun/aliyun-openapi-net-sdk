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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeGreyTagRouteResponseUnmarshaller
    {
        public static DescribeGreyTagRouteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGreyTagRouteResponse describeGreyTagRouteResponse = new DescribeGreyTagRouteResponse();

			describeGreyTagRouteResponse.HttpResponse = _ctx.HttpResponse;
			describeGreyTagRouteResponse.RequestId = _ctx.StringValue("DescribeGreyTagRoute.RequestId");
			describeGreyTagRouteResponse.Message = _ctx.StringValue("DescribeGreyTagRoute.Message");
			describeGreyTagRouteResponse.TraceId = _ctx.StringValue("DescribeGreyTagRoute.TraceId");
			describeGreyTagRouteResponse.ErrorCode = _ctx.StringValue("DescribeGreyTagRoute.ErrorCode");
			describeGreyTagRouteResponse.Code = _ctx.StringValue("DescribeGreyTagRoute.Code");
			describeGreyTagRouteResponse.Success = _ctx.BooleanValue("DescribeGreyTagRoute.Success");

			DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data data = new DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data();
			data.GreyTagRouteId = _ctx.LongValue("DescribeGreyTagRoute.Data.GreyTagRouteId");
			data.Name = _ctx.StringValue("DescribeGreyTagRoute.Data.Name");
			data.Description = _ctx.StringValue("DescribeGreyTagRoute.Data.Description");
			data.CreateTime = _ctx.LongValue("DescribeGreyTagRoute.Data.CreateTime");
			data.UpdateTime = _ctx.LongValue("DescribeGreyTagRoute.Data.UpdateTime");
			data.AppId = _ctx.StringValue("DescribeGreyTagRoute.Data.AppId");

			List<DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_ScRule> data_scRules = new List<DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_ScRule>();
			for (int i = 0; i < _ctx.Length("DescribeGreyTagRoute.Data.ScRules.Length"); i++) {
				DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_ScRule scRule = new DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_ScRule();
				scRule.Path = _ctx.StringValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].path");
				scRule.Condition = _ctx.StringValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].condition");

				List<DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_ScRule.DescribeGreyTagRoute_Scrulesitem> scRule_items = new List<DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_ScRule.DescribeGreyTagRoute_Scrulesitem>();
				for (int j = 0; j < _ctx.Length("DescribeGreyTagRoute.Data.ScRules["+ i +"].Items.Length"); j++) {
					DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_ScRule.DescribeGreyTagRoute_Scrulesitem scrulesitem = new DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_ScRule.DescribeGreyTagRoute_Scrulesitem();
					scrulesitem.Type = _ctx.StringValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].Items["+ j +"].type");
					scrulesitem.Name = _ctx.StringValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].Items["+ j +"].name");
					scrulesitem._Operator = _ctx.StringValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].Items["+ j +"].operator");
					scrulesitem._Value = _ctx.StringValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].Items["+ j +"].value");
					scrulesitem.Cond = _ctx.StringValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].Items["+ j +"].cond");
					scrulesitem.Index = _ctx.IntegerValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].Items["+ j +"].index");
					scrulesitem.Expr = _ctx.StringValue("DescribeGreyTagRoute.Data.ScRules["+ i +"].Items["+ j +"].expr");

					scRule_items.Add(scrulesitem);
				}
				scRule.Items = scRule_items;

				data_scRules.Add(scRule);
			}
			data.ScRules = data_scRules;

			List<DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_DubboRule> data_dubboRules = new List<DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_DubboRule>();
			for (int i = 0; i < _ctx.Length("DescribeGreyTagRoute.Data.DubboRules.Length"); i++) {
				DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_DubboRule dubboRule = new DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_DubboRule();
				dubboRule.ServiceName = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].serviceName");
				dubboRule.Group = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].group");
				dubboRule.Version = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].version");
				dubboRule.MethodName = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].methodName");
				dubboRule.Condition = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].condition");

				List<DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_DubboRule.DescribeGreyTagRoute_Item> dubboRule_items1 = new List<DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_DubboRule.DescribeGreyTagRoute_Item>();
				for (int j = 0; j < _ctx.Length("DescribeGreyTagRoute.Data.DubboRules["+ i +"].Items.Length"); j++) {
					DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_DubboRule.DescribeGreyTagRoute_Item item = new DescribeGreyTagRouteResponse.DescribeGreyTagRoute_Data.DescribeGreyTagRoute_DubboRule.DescribeGreyTagRoute_Item();
					item.Index = _ctx.IntegerValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].Items["+ j +"].index");
					item.Expr = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].Items["+ j +"].expr");
					item._Operator = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].Items["+ j +"].operator");
					item._Value = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].Items["+ j +"].value");
					item.Cond = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].Items["+ j +"].cond");
					item.Type = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].Items["+ j +"].type");
					item.Name = _ctx.StringValue("DescribeGreyTagRoute.Data.DubboRules["+ i +"].Items["+ j +"].name");

					dubboRule_items1.Add(item);
				}
				dubboRule.Items1 = dubboRule_items1;

				data_dubboRules.Add(dubboRule);
			}
			data.DubboRules = data_dubboRules;
			describeGreyTagRouteResponse.Data = data;
        
			return describeGreyTagRouteResponse;
        }
    }
}
