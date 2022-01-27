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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeRestoreOrderResponseUnmarshaller
    {
        public static DescribeRestoreOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRestoreOrderResponse describeRestoreOrderResponse = new DescribeRestoreOrderResponse();

			describeRestoreOrderResponse.HttpResponse = _ctx.HttpResponse;
			describeRestoreOrderResponse.RequestId = _ctx.StringValue("DescribeRestoreOrder.RequestId");
			describeRestoreOrderResponse.Success = _ctx.BooleanValue("DescribeRestoreOrder.Success");

			DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO restoreOrderDO = new DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO();

			List<DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_DrdsOrderDOListItem> restoreOrderDO_drdsOrderDOList = new List<DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_DrdsOrderDOListItem>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreOrder.RestoreOrderDO.DrdsOrderDOList.Length"); i++) {
				DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_DrdsOrderDOListItem drdsOrderDOListItem = new DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_DrdsOrderDOListItem();
				drdsOrderDOListItem.RegionId = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.DrdsOrderDOList["+ i +"].RegionId");
				drdsOrderDOListItem.AzoneId = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.DrdsOrderDOList["+ i +"].AzoneId");
				drdsOrderDOListItem.Network = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.DrdsOrderDOList["+ i +"].Network");
				drdsOrderDOListItem.VpcId = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.DrdsOrderDOList["+ i +"].VpcId");
				drdsOrderDOListItem.VSwtichId = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.DrdsOrderDOList["+ i +"].VSwtichId");
				drdsOrderDOListItem.InstSpec = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.DrdsOrderDOList["+ i +"].InstSpec");

				restoreOrderDO_drdsOrderDOList.Add(drdsOrderDOListItem);
			}
			restoreOrderDO.DrdsOrderDOList = restoreOrderDO_drdsOrderDOList;

			List<DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_RdsOrderDOListItem> restoreOrderDO_rdsOrderDOList = new List<DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_RdsOrderDOListItem>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList.Length"); i++) {
				DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_RdsOrderDOListItem rdsOrderDOListItem = new DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_RdsOrderDOListItem();
				rdsOrderDOListItem.RegionId = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList["+ i +"].RegionId");
				rdsOrderDOListItem.AzoneId = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList["+ i +"].AzoneId");
				rdsOrderDOListItem.Engine = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList["+ i +"].Engine");
				rdsOrderDOListItem.Version = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList["+ i +"].Version");
				rdsOrderDOListItem.InstanceClass = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList["+ i +"].InstanceClass");
				rdsOrderDOListItem.DbInstanceStorage = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList["+ i +"].DbInstanceStorage");
				rdsOrderDOListItem.Network = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList["+ i +"].Network");
				rdsOrderDOListItem.Num = _ctx.LongValue("DescribeRestoreOrder.RestoreOrderDO.RdsOrderDOList["+ i +"].Num");

				restoreOrderDO_rdsOrderDOList.Add(rdsOrderDOListItem);
			}
			restoreOrderDO.RdsOrderDOList = restoreOrderDO_rdsOrderDOList;

			List<DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_PolarOrderDOListItem> restoreOrderDO_polarOrderDOList = new List<DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_PolarOrderDOListItem>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList.Length"); i++) {
				DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_PolarOrderDOListItem polarOrderDOListItem = new DescribeRestoreOrderResponse.DescribeRestoreOrder_RestoreOrderDO.DescribeRestoreOrder_PolarOrderDOListItem();
				polarOrderDOListItem.RegionId = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList["+ i +"].RegionId");
				polarOrderDOListItem.AzoneId = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList["+ i +"].AzoneId");
				polarOrderDOListItem.Engine = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList["+ i +"].Engine");
				polarOrderDOListItem.Version = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList["+ i +"].Version");
				polarOrderDOListItem.InstanceClass = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList["+ i +"].InstanceClass");
				polarOrderDOListItem.DbInstanceStorage = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList["+ i +"].DbInstanceStorage");
				polarOrderDOListItem.Network = _ctx.StringValue("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList["+ i +"].Network");
				polarOrderDOListItem.Num = _ctx.LongValue("DescribeRestoreOrder.RestoreOrderDO.PolarOrderDOList["+ i +"].Num");

				restoreOrderDO_polarOrderDOList.Add(polarOrderDOListItem);
			}
			restoreOrderDO.PolarOrderDOList = restoreOrderDO_polarOrderDOList;
			describeRestoreOrderResponse.RestoreOrderDO = restoreOrderDO;
        
			return describeRestoreOrderResponse;
        }
    }
}
