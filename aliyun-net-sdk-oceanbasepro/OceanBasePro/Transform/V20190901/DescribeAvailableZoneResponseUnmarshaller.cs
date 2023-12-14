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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeAvailableZoneResponseUnmarshaller
    {
        public static DescribeAvailableZoneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableZoneResponse describeAvailableZoneResponse = new DescribeAvailableZoneResponse();

			describeAvailableZoneResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableZoneResponse.RequestId = _ctx.StringValue("DescribeAvailableZone.RequestId");

			DescribeAvailableZoneResponse.DescribeAvailableZone_Data data = new DescribeAvailableZoneResponse.DescribeAvailableZone_Data();

			List<DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem> data_availableZones = new List<DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableZone.Data.AvailableZones.Length"); i++) {
				DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem availableZonesItem = new DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem();
				availableZonesItem.Region = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].Region");
				availableZonesItem.Zones = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].Zones");
				availableZonesItem.Channel = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].Channel");
				availableZonesItem.DeployType = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].DeployType");
				availableZonesItem.InstanceType = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].InstanceType");
				availableZonesItem.Series = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].Series");

				List<DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem> availableZonesItem_supportSpecifications = new List<DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications.Length"); j++) {
					DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem supportSpecificationsItem = new DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem();
					supportSpecificationsItem.Spec = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].Spec");
					supportSpecificationsItem.InstanceClass = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].InstanceClass");

					List<string> supportSpecificationsItem_diskTypes = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].DiskTypes.Length"); k++) {
						supportSpecificationsItem_diskTypes.Add(_ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].DiskTypes["+ k +"]"));
					}
					supportSpecificationsItem.DiskTypes = supportSpecificationsItem_diskTypes;

					DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem.DescribeAvailableZone_DiskSizeRange diskSizeRange = new DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem.DescribeAvailableZone_DiskSizeRange();
					diskSizeRange.Step = _ctx.LongValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].DiskSizeRange.Step");
					diskSizeRange.Max = _ctx.LongValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].DiskSizeRange.Max");
					diskSizeRange.Min = _ctx.LongValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].DiskSizeRange.Min");
					supportSpecificationsItem.DiskSizeRange = diskSizeRange;

					List<DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem.DescribeAvailableZone_SupportEngineVersionsItem> supportSpecificationsItem_supportEngineVersions = new List<DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem.DescribeAvailableZone_SupportEngineVersionsItem>();
					for (int k = 0; k < _ctx.Length("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].SupportEngineVersions.Length"); k++) {
						DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem.DescribeAvailableZone_SupportEngineVersionsItem supportEngineVersionsItem = new DescribeAvailableZoneResponse.DescribeAvailableZone_Data.DescribeAvailableZone_AvailableZonesItem.DescribeAvailableZone_SupportSpecificationsItem.DescribeAvailableZone_SupportEngineVersionsItem();
						supportEngineVersionsItem.ObVersion = _ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].SupportEngineVersions["+ k +"].ObVersion");
						supportEngineVersionsItem.SupportIsolationOptimization = _ctx.BooleanValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].SupportEngineVersions["+ k +"].SupportIsolationOptimization");

						List<string> supportEngineVersionsItem_supportReplicaModes = new List<string>();
						for (int l = 0; l < _ctx.Length("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].SupportEngineVersions["+ k +"].SupportReplicaModes.Length"); l++) {
							supportEngineVersionsItem_supportReplicaModes.Add(_ctx.StringValue("DescribeAvailableZone.Data.AvailableZones["+ i +"].SupportSpecifications["+ j +"].SupportEngineVersions["+ k +"].SupportReplicaModes["+ l +"]"));
						}
						supportEngineVersionsItem.SupportReplicaModes = supportEngineVersionsItem_supportReplicaModes;

						supportSpecificationsItem_supportEngineVersions.Add(supportEngineVersionsItem);
					}
					supportSpecificationsItem.SupportEngineVersions = supportSpecificationsItem_supportEngineVersions;

					availableZonesItem_supportSpecifications.Add(supportSpecificationsItem);
				}
				availableZonesItem.SupportSpecifications = availableZonesItem_supportSpecifications;

				data_availableZones.Add(availableZonesItem);
			}
			data.AvailableZones = data_availableZones;
			describeAvailableZoneResponse.Data = data;
        
			return describeAvailableZoneResponse;
        }
    }
}
