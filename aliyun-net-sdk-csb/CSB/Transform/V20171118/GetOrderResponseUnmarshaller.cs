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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CSB.Model.V20171118;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class GetOrderResponseUnmarshaller
    {
        public static GetOrderResponse Unmarshall(UnmarshallerContext context)
        {
			GetOrderResponse getOrderResponse = new GetOrderResponse();

			getOrderResponse.HttpResponse = context.HttpResponse;
			getOrderResponse.Code = context.IntegerValue("GetOrder.Code");
			getOrderResponse.Message = context.StringValue("GetOrder.Message");
			getOrderResponse.RequestId = context.StringValue("GetOrder.RequestId");

			GetOrderResponse.GetOrder_Data data = new GetOrderResponse.GetOrder_Data();

			GetOrderResponse.GetOrder_Data.GetOrder_Order order = new GetOrderResponse.GetOrder_Data.GetOrder_Order();
			order.Alias = context.StringValue("GetOrder.Data.Order.Alias");
			order.CredentialGroupId = context.LongValue("GetOrder.Data.Order.CredentialGroupId");
			order.CsbId = context.LongValue("GetOrder.Data.Order.CsbId");
			order.DauthGroupName = context.StringValue("GetOrder.Data.Order.DauthGroupName");
			order.GmtCreate = context.LongValue("GetOrder.Data.Order.GmtCreate");
			order.GmtModified = context.LongValue("GetOrder.Data.Order.GmtModified");
			order.GroupName = context.StringValue("GetOrder.Data.Order.GroupName");
			order.Id = context.LongValue("GetOrder.Data.Order.Id");
			order.ProjectName = context.StringValue("GetOrder.Data.Order.ProjectName");
			order.ServiceId = context.LongValue("GetOrder.Data.Order.ServiceId");
			order.ServiceName = context.StringValue("GetOrder.Data.Order.ServiceName");
			order.ServiceStatus = context.IntegerValue("GetOrder.Data.Order.ServiceStatus");
			order.ServiceVersion = context.StringValue("GetOrder.Data.Order.ServiceVersion");
			order.StatisticName = context.StringValue("GetOrder.Data.Order.StatisticName");
			order.Status = context.IntegerValue("GetOrder.Data.Order.Status");
			order.StrictWhiteListJson = context.StringValue("GetOrder.Data.Order.StrictWhiteListJson");
			order.UserId = context.StringValue("GetOrder.Data.Order.UserId");

			List<string> order_strictWhiteList = new List<string>();
			for (int i = 0; i < context.Length("GetOrder.Data.Order.StrictWhiteList.Length"); i++) {
				order_strictWhiteList.Add(context.StringValue("GetOrder.Data.Order.StrictWhiteList["+ i +"]"));
			}
			order.StrictWhiteList = order_strictWhiteList;

			GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_Service service = new GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_Service();
			service.AccessParamsJSON = context.StringValue("GetOrder.Data.Order.Service.AccessParamsJSON");
			service.Active = context.BooleanValue("GetOrder.Data.Order.Service.Active");
			service.Alias = context.StringValue("GetOrder.Data.Order.Service.Alias");
			service.AllVisiable = context.BooleanValue("GetOrder.Data.Order.Service.AllVisiable");
			service.ConsumeTypesJSON = context.StringValue("GetOrder.Data.Order.Service.ConsumeTypesJSON");
			service.CreateTime = context.LongValue("GetOrder.Data.Order.Service.CreateTime");
			service.CsbId = context.LongValue("GetOrder.Data.Order.Service.CsbId");
			service.ErrDefJSON = context.StringValue("GetOrder.Data.Order.Service.ErrDefJSON");
			service.Id = context.LongValue("GetOrder.Data.Order.Service.Id");
			service.InterfaceName = context.StringValue("GetOrder.Data.Order.Service.InterfaceName");
			service.OldVersion = context.StringValue("GetOrder.Data.Order.Service.OldVersion");
			service.OttFlag = context.BooleanValue("GetOrder.Data.Order.Service.OttFlag");
			service.OwnerId = context.StringValue("GetOrder.Data.Order.Service.OwnerId");
			service.PrincipalName = context.StringValue("GetOrder.Data.Order.Service.PrincipalName");
			service.ProjectId = context.StringValue("GetOrder.Data.Order.Service.ProjectId");
			service.ProjectName = context.StringValue("GetOrder.Data.Order.Service.ProjectName");
			service.ProvideType = context.StringValue("GetOrder.Data.Order.Service.ProvideType");
			service.SSL = context.BooleanValue("GetOrder.Data.Order.Service.SSL");
			service.Scope = context.StringValue("GetOrder.Data.Order.Service.Scope");
			service.ServiceName = context.StringValue("GetOrder.Data.Order.Service.ServiceName");
			service.ServiceProviderType = context.StringValue("GetOrder.Data.Order.Service.ServiceProviderType");
			service.ServiceVersion = context.StringValue("GetOrder.Data.Order.Service.ServiceVersion");
			service.SkipAuth = context.BooleanValue("GetOrder.Data.Order.Service.SkipAuth");
			service.StatisticName = context.StringValue("GetOrder.Data.Order.Service.StatisticName");
			service.Status = context.IntegerValue("GetOrder.Data.Order.Service.Status");
			service.UserId = context.LongValue("GetOrder.Data.Order.Service.UserId");
			service.ValidConsumeTypes = context.BooleanValue("GetOrder.Data.Order.Service.ValidConsumeTypes");
			service.ValidProvideType = context.BooleanValue("GetOrder.Data.Order.Service.ValidProvideType");
			order.Service = service;

			GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_SlaInfo slaInfo = new GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_SlaInfo();
			slaInfo.Qph = context.StringValue("GetOrder.Data.Order.SlaInfo.Qph");
			slaInfo.Qps = context.StringValue("GetOrder.Data.Order.SlaInfo.Qps");
			order.SlaInfo = slaInfo;

			GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_Total total = new GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_Total();
			total.ErrorNum = context.IntegerValue("GetOrder.Data.Order.Total.ErrorNum");
			total.Total = context.IntegerValue("GetOrder.Data.Order.Total.Total");
			order.Total = total;

			List<GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_ErrorTypeCatagory> order_errorTypeCatagoryList = new List<GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_ErrorTypeCatagory>();
			for (int i = 0; i < context.Length("GetOrder.Data.Order.ErrorTypeCatagoryList.Length"); i++) {
				GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_ErrorTypeCatagory errorTypeCatagory = new GetOrderResponse.GetOrder_Data.GetOrder_Order.GetOrder_ErrorTypeCatagory();
				errorTypeCatagory.Total = context.IntegerValue("GetOrder.Data.Order.ErrorTypeCatagoryList["+ i +"].Total");
				errorTypeCatagory.ErrorNum = context.IntegerValue("GetOrder.Data.Order.ErrorTypeCatagoryList["+ i +"].ErrorNum");
				errorTypeCatagory.Name = context.StringValue("GetOrder.Data.Order.ErrorTypeCatagoryList["+ i +"].Name");

				order_errorTypeCatagoryList.Add(errorTypeCatagory);
			}
			order.ErrorTypeCatagoryList = order_errorTypeCatagoryList;
			data.Order = order;
			getOrderResponse.Data = data;
        
			return getOrderResponse;
        }
    }
}