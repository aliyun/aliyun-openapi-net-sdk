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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeExpressCloudConnectionsResponseUnmarshaller
    {
        public static DescribeExpressCloudConnectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExpressCloudConnectionsResponse describeExpressCloudConnectionsResponse = new DescribeExpressCloudConnectionsResponse();

			describeExpressCloudConnectionsResponse.HttpResponse = _ctx.HttpResponse;
			describeExpressCloudConnectionsResponse.RequestId = _ctx.StringValue("DescribeExpressCloudConnections.RequestId");
			describeExpressCloudConnectionsResponse.PageNumber = _ctx.IntegerValue("DescribeExpressCloudConnections.PageNumber");
			describeExpressCloudConnectionsResponse.PageSize = _ctx.IntegerValue("DescribeExpressCloudConnections.PageSize");
			describeExpressCloudConnectionsResponse.TotalCount = _ctx.IntegerValue("DescribeExpressCloudConnections.TotalCount");

			List<DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType> describeExpressCloudConnectionsResponse_expressCloudConnectionSet = new List<DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType>();
			for (int i = 0; i < _ctx.Length("DescribeExpressCloudConnections.ExpressCloudConnectionSet.Length"); i++) {
				DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType expressCloudConnectionType = new DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType();
				expressCloudConnectionType.InstanceId = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].InstanceId");
				expressCloudConnectionType.Status = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Status");
				expressCloudConnectionType.Name = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Name");
				expressCloudConnectionType.Description = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Description");
				expressCloudConnectionType.GmtCreate = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].GmtCreate");
				expressCloudConnectionType.GmtModify = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].GmtModify");
				expressCloudConnectionType.PeerCity = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].PeerCity");
				expressCloudConnectionType.PeerLocation = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].PeerLocation");
				expressCloudConnectionType.PortType = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].PortType");
				expressCloudConnectionType.Bandwidth = _ctx.IntegerValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Bandwidth");
				expressCloudConnectionType.Distance = _ctx.IntegerValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Distance");
				expressCloudConnectionType.RedundantEccId = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].RedundantEccId");
				expressCloudConnectionType.CircuitCode = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].CircuitCode");
				expressCloudConnectionType.Isp = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Isp");
				expressCloudConnectionType.Type = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Type");
				expressCloudConnectionType.IdcSP = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].IdcSP");
				expressCloudConnectionType.BusinessStatus = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].BusinessStatus");
				expressCloudConnectionType.HasReservationData = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].HasReservationData");
				expressCloudConnectionType.ReservationBandwidth = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ReservationBandwidth");
				expressCloudConnectionType.ReservationInternetChargeType = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ReservationInternetChargeType");
				expressCloudConnectionType.ReservationActiveTime = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ReservationActiveTime");
				expressCloudConnectionType.ReservationOrderType = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ReservationOrderType");
				expressCloudConnectionType.ApplicationType = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ApplicationType");
				expressCloudConnectionType.ApplicationId = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ApplicationId");
				expressCloudConnectionType.ApplicationStatus = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ApplicationStatus");
				expressCloudConnectionType.ApplicationBandwidth = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ApplicationBandwidth");
				expressCloudConnectionType.EndTime = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].EndTime");
				expressCloudConnectionType.ChargeType = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ChargeType");
				expressCloudConnectionType.ContactTel = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ContactTel");
				expressCloudConnectionType.ContactMail = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ContactMail");
				expressCloudConnectionType.IDCardNo = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].IDCardNo");
				expressCloudConnectionType.EstimatedTime = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].EstimatedTime");
				expressCloudConnectionType.BgpAs = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].BgpAs");
				expressCloudConnectionType.PeIp = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].PeIp");
				expressCloudConnectionType.CeIp = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].CeIp");
				expressCloudConnectionType.ConstructionPeriod = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ConstructionPeriod");

				List<DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType.DescribeExpressCloudConnections_VirtualBorderRouterModel> expressCloudConnectionType_virtualBorderRouterModels = new List<DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType.DescribeExpressCloudConnections_VirtualBorderRouterModel>();
				for (int j = 0; j < _ctx.Length("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].VirtualBorderRouterModels.Length"); j++) {
					DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType.DescribeExpressCloudConnections_VirtualBorderRouterModel virtualBorderRouterModel = new DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType.DescribeExpressCloudConnections_VirtualBorderRouterModel();
					virtualBorderRouterModel.InstanceId = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].VirtualBorderRouterModels["+ j +"].InstanceId");
					virtualBorderRouterModel.AccessPointId = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].VirtualBorderRouterModels["+ j +"].AccessPointId");
					virtualBorderRouterModel.PhysicalConnectionId = _ctx.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].VirtualBorderRouterModels["+ j +"].PhysicalConnectionId");

					expressCloudConnectionType_virtualBorderRouterModels.Add(virtualBorderRouterModel);
				}
				expressCloudConnectionType.VirtualBorderRouterModels = expressCloudConnectionType_virtualBorderRouterModels;

				describeExpressCloudConnectionsResponse_expressCloudConnectionSet.Add(expressCloudConnectionType);
			}
			describeExpressCloudConnectionsResponse.ExpressCloudConnectionSet = describeExpressCloudConnectionsResponse_expressCloudConnectionSet;
        
			return describeExpressCloudConnectionsResponse;
        }
    }
}
