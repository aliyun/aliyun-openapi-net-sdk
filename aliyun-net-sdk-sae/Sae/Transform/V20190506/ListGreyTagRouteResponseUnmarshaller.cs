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
    public class ListGreyTagRouteResponseUnmarshaller
    {
        public static ListGreyTagRouteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGreyTagRouteResponse listGreyTagRouteResponse = new ListGreyTagRouteResponse();

			listGreyTagRouteResponse.HttpResponse = _ctx.HttpResponse;
			listGreyTagRouteResponse.Message = _ctx.StringValue("ListGreyTagRoute.Message");
			listGreyTagRouteResponse.RequestId = _ctx.StringValue("ListGreyTagRoute.RequestId");
			listGreyTagRouteResponse.TraceId = _ctx.StringValue("ListGreyTagRoute.TraceId");
			listGreyTagRouteResponse.ErrorCode = _ctx.StringValue("ListGreyTagRoute.ErrorCode");
			listGreyTagRouteResponse.Code = _ctx.StringValue("ListGreyTagRoute.Code");
			listGreyTagRouteResponse.Success = _ctx.BooleanValue("ListGreyTagRoute.Success");

			ListGreyTagRouteResponse.ListGreyTagRoute_Data data = new ListGreyTagRouteResponse.ListGreyTagRoute_Data();
			data.PageSize = _ctx.IntegerValue("ListGreyTagRoute.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("ListGreyTagRoute.Data.CurrentPage");
			data.TotalSize = _ctx.LongValue("ListGreyTagRoute.Data.TotalSize");

			List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem> data_result = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListGreyTagRoute.Data.Result.Length"); i++) {
				ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem resultItem = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem();
				resultItem.Description = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].Description");
				resultItem.GreyTagRouteId = _ctx.LongValue("ListGreyTagRoute.Data.Result["+ i +"].GreyTagRouteId");
				resultItem.CreateTime = _ctx.LongValue("ListGreyTagRoute.Data.Result["+ i +"].CreateTime");
				resultItem.UpdateTime = _ctx.LongValue("ListGreyTagRoute.Data.Result["+ i +"].UpdateTime");
				resultItem.Name = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].Name");

				List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule> resultItem_scRules = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule>();
				for (int j = 0; j < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].ScRules.Length"); j++) {
					ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule scRule = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule();
					scRule.Path = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].path");
					scRule.Condition = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].condition");

					List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule.ListGreyTagRoute_Item> scRule_items = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule.ListGreyTagRoute_Item>();
					for (int k = 0; k < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items.Length"); k++) {
						ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule.ListGreyTagRoute_Item item = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule.ListGreyTagRoute_Item();
						item.Name = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].name");
						item.Index = _ctx.IntegerValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].index");
						item.Expr = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].expr");
						item.Type = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].type");
						item.Cond = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].cond");
						item._Value = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].value");
						item._Operator = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].operator");

						scRule_items.Add(item);
					}
					scRule.Items = scRule_items;

					resultItem_scRules.Add(scRule);
				}
				resultItem.ScRules = resultItem_scRules;

				List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule> resultItem_dubboRules = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule>();
				for (int j = 0; j < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].DubboRules.Length"); j++) {
					ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule dubboRule = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule();
					dubboRule.Condition = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].condition");
					dubboRule.MethodName = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].methodName");
					dubboRule.ServiceName = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].serviceName");
					dubboRule.Version = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].version");
					dubboRule.Group = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].group");

					List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule.ListGreyTagRoute_Item2> dubboRule_items1 = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule.ListGreyTagRoute_Item2>();
					for (int k = 0; k < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items.Length"); k++) {
						ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule.ListGreyTagRoute_Item2 item2 = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule.ListGreyTagRoute_Item2();
						item2.Name = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].name");
						item2.Index = _ctx.IntegerValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].index");
						item2.Expr = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].expr");
						item2.Type = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].type");
						item2.Cond = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].cond");
						item2._Value = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].value");
						item2._Operator = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].operator");

						dubboRule_items1.Add(item2);
					}
					dubboRule.Items1 = dubboRule_items1;

					resultItem_dubboRules.Add(dubboRule);
				}
				resultItem.DubboRules = resultItem_dubboRules;

				data_result.Add(resultItem);
			}
			data.Result = data_result;
			listGreyTagRouteResponse.Data = data;
        
			return listGreyTagRouteResponse;
        }
    }
}
