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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeAvailableResourceResponseUnmarshaller
    {
        public static DescribeAvailableResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAvailableResourceResponse describeAvailableResourceResponse = new DescribeAvailableResourceResponse();

			describeAvailableResourceResponse.HttpResponse = context.HttpResponse;
			describeAvailableResourceResponse.RequestId = context.StringValue("DescribeAvailableResource.RequestId");
			describeAvailableResourceResponse.RegionId = context.StringValue("DescribeAvailableResource.RegionId");

			List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone> describeAvailableResourceResponse_availableZoneList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone>();
			for (int i = 0; i < context.Length("DescribeAvailableResource.AvailableZoneList.Length"); i++) {
				DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone availableZone = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone();
				availableZone.ZoneId = context.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].ZoneId");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial> availableZone_supportedSerialList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial>();
				for (int j = 0; j < context.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial supportedSerial = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial();
					supportedSerial.Serial = context.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList["+ j +"].Serial");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial.DescribeAvailableResource_SupportedInstanceClass> supportedSerial_supportedInstanceClassList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial.DescribeAvailableResource_SupportedInstanceClass>();
					for (int k = 0; k < context.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList["+ j +"].SupportedInstanceClassList.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial.DescribeAvailableResource_SupportedInstanceClass supportedInstanceClass = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial.DescribeAvailableResource_SupportedInstanceClass();
						supportedInstanceClass.InstanceClass = context.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList["+ j +"].SupportedInstanceClassList["+ k +"].InstanceClass");
						supportedInstanceClass.Tips = context.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList["+ j +"].SupportedInstanceClassList["+ k +"].Tips");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount> supportedInstanceClass_supportedNodeCountList = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount>();
						for (int l = 0; l < context.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList["+ j +"].SupportedInstanceClassList["+ k +"].SupportedNodeCountList.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount supportedNodeCount = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedSerial.DescribeAvailableResource_SupportedInstanceClass.DescribeAvailableResource_SupportedNodeCount();
							supportedNodeCount.NodeCount = context.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList["+ j +"].SupportedInstanceClassList["+ k +"].SupportedNodeCountList["+ l +"].NodeCount");

							List<string> supportedNodeCount_storageSize = new List<string>();
							for (int m = 0; m < context.Length("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList["+ j +"].SupportedInstanceClassList["+ k +"].SupportedNodeCountList["+ l +"].StorageSize.Length"); m++) {
								supportedNodeCount_storageSize.Add(context.StringValue("DescribeAvailableResource.AvailableZoneList["+ i +"].SupportedSerialList["+ j +"].SupportedInstanceClassList["+ k +"].SupportedNodeCountList["+ l +"].StorageSize["+ m +"]"));
							}
							supportedNodeCount.StorageSize = supportedNodeCount_storageSize;

							supportedInstanceClass_supportedNodeCountList.Add(supportedNodeCount);
						}
						supportedInstanceClass.SupportedNodeCountList = supportedInstanceClass_supportedNodeCountList;

						supportedSerial_supportedInstanceClassList.Add(supportedInstanceClass);
					}
					supportedSerial.SupportedInstanceClassList = supportedSerial_supportedInstanceClassList;

					availableZone_supportedSerialList.Add(supportedSerial);
				}
				availableZone.SupportedSerialList = availableZone_supportedSerialList;

				describeAvailableResourceResponse_availableZoneList.Add(availableZone);
			}
			describeAvailableResourceResponse.AvailableZoneList = describeAvailableResourceResponse_availableZoneList;
        
			return describeAvailableResourceResponse;
        }
    }
}
