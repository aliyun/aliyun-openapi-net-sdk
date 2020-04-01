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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribePlanogramEslDevicesResponseUnmarshaller
    {
        public static DescribePlanogramEslDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePlanogramEslDevicesResponse describePlanogramEslDevicesResponse = new DescribePlanogramEslDevicesResponse();

			describePlanogramEslDevicesResponse.HttpResponse = context.HttpResponse;
			describePlanogramEslDevicesResponse.Code = context.StringValue("DescribePlanogramEslDevices.Code");
			describePlanogramEslDevicesResponse.DynamicCode = context.StringValue("DescribePlanogramEslDevices.DynamicCode");
			describePlanogramEslDevicesResponse.DynamicMessage = context.StringValue("DescribePlanogramEslDevices.DynamicMessage");
			describePlanogramEslDevicesResponse.ErrorCode = context.StringValue("DescribePlanogramEslDevices.ErrorCode");
			describePlanogramEslDevicesResponse.ErrorMessage = context.StringValue("DescribePlanogramEslDevices.ErrorMessage");
			describePlanogramEslDevicesResponse.Message = context.StringValue("DescribePlanogramEslDevices.Message");
			describePlanogramEslDevicesResponse.RequestId = context.StringValue("DescribePlanogramEslDevices.RequestId");
			describePlanogramEslDevicesResponse.Shelf = context.StringValue("DescribePlanogramEslDevices.Shelf");
			describePlanogramEslDevicesResponse.StoreId = context.StringValue("DescribePlanogramEslDevices.StoreId");
			describePlanogramEslDevicesResponse.Success = context.BooleanValue("DescribePlanogramEslDevices.Success");

			List<DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo> describePlanogramEslDevicesResponse_eslDeviceLayerInfos = new List<DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo>();
			for (int i = 0; i < context.Length("DescribePlanogramEslDevices.EslDeviceLayerInfos.Length"); i++) {
				DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo eslDeviceLayerInfo = new DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo();
				eslDeviceLayerInfo.Layer = context.IntegerValue("DescribePlanogramEslDevices.EslDeviceLayerInfos["+ i +"].Layer");

				List<DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo.DescribePlanogramEslDevices_EslDevicePositionInfo> eslDeviceLayerInfo_eslDevicePositionInfos = new List<DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo.DescribePlanogramEslDevices_EslDevicePositionInfo>();
				for (int j = 0; j < context.Length("DescribePlanogramEslDevices.EslDeviceLayerInfos["+ i +"].EslDevicePositionInfos.Length"); j++) {
					DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo.DescribePlanogramEslDevices_EslDevicePositionInfo eslDevicePositionInfo = new DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo.DescribePlanogramEslDevices_EslDevicePositionInfo();
					eslDevicePositionInfo.Column = context.StringValue("DescribePlanogramEslDevices.EslDeviceLayerInfos["+ i +"].EslDevicePositionInfos["+ j +"].Column");

					List<DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo.DescribePlanogramEslDevices_EslDevicePositionInfo.DescribePlanogramEslDevices_EslDevicePlanogramInfo> eslDevicePositionInfo_eslDevicePlanogramInfos = new List<DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo.DescribePlanogramEslDevices_EslDevicePositionInfo.DescribePlanogramEslDevices_EslDevicePlanogramInfo>();
					for (int k = 0; k < context.Length("DescribePlanogramEslDevices.EslDeviceLayerInfos["+ i +"].EslDevicePositionInfos["+ j +"].EslDevicePlanogramInfos.Length"); k++) {
						DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo.DescribePlanogramEslDevices_EslDevicePositionInfo.DescribePlanogramEslDevices_EslDevicePlanogramInfo eslDevicePlanogramInfo = new DescribePlanogramEslDevicesResponse.DescribePlanogramEslDevices_EslDeviceLayerInfo.DescribePlanogramEslDevices_EslDevicePositionInfo.DescribePlanogramEslDevices_EslDevicePlanogramInfo();
						eslDevicePlanogramInfo.EslBarCode = context.StringValue("DescribePlanogramEslDevices.EslDeviceLayerInfos["+ i +"].EslDevicePositionInfos["+ j +"].EslDevicePlanogramInfos["+ k +"].EslBarCode");
						eslDevicePlanogramInfo.EslModel = context.StringValue("DescribePlanogramEslDevices.EslDeviceLayerInfos["+ i +"].EslDevicePositionInfos["+ j +"].EslDevicePlanogramInfos["+ k +"].EslModel");
						eslDevicePlanogramInfo.ItemBarCode = context.StringValue("DescribePlanogramEslDevices.EslDeviceLayerInfos["+ i +"].EslDevicePositionInfos["+ j +"].EslDevicePlanogramInfos["+ k +"].ItemBarCode");
						eslDevicePlanogramInfo.ItemTitle = context.StringValue("DescribePlanogramEslDevices.EslDeviceLayerInfos["+ i +"].EslDevicePositionInfos["+ j +"].EslDevicePlanogramInfos["+ k +"].ItemTitle");

						eslDevicePositionInfo_eslDevicePlanogramInfos.Add(eslDevicePlanogramInfo);
					}
					eslDevicePositionInfo.EslDevicePlanogramInfos = eslDevicePositionInfo_eslDevicePlanogramInfos;

					eslDeviceLayerInfo_eslDevicePositionInfos.Add(eslDevicePositionInfo);
				}
				eslDeviceLayerInfo.EslDevicePositionInfos = eslDeviceLayerInfo_eslDevicePositionInfos;

				describePlanogramEslDevicesResponse_eslDeviceLayerInfos.Add(eslDeviceLayerInfo);
			}
			describePlanogramEslDevicesResponse.EslDeviceLayerInfos = describePlanogramEslDevicesResponse_eslDeviceLayerInfos;
        
			return describePlanogramEslDevicesResponse;
        }
    }
}
