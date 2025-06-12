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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeDBClusterAttributeResponseUnmarshaller
    {
        public static DescribeDBClusterAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterAttributeResponse describeDBClusterAttributeResponse = new DescribeDBClusterAttributeResponse();

			describeDBClusterAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterAttributeResponse.RequestId = _ctx.StringValue("DescribeDBClusterAttribute.RequestId");

			DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster dBCluster = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster();
			dBCluster.VpcId = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.VpcId");
			dBCluster.SupportBackup = _ctx.IntegerValue("DescribeDBClusterAttribute.DBCluster.SupportBackup");
			dBCluster.SupportOss = _ctx.IntegerValue("DescribeDBClusterAttribute.DBCluster.SupportOss");
			dBCluster.EncryptionType = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.EncryptionType");
			dBCluster.DBNodeCount = _ctx.LongValue("DescribeDBClusterAttribute.DBCluster.DBNodeCount");
			dBCluster.MaintainTime = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.MaintainTime");
			dBCluster.CreateTime = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.CreateTime");
			dBCluster.PayType = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.PayType");
			dBCluster.PublicConnectionString = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.PublicConnectionString");
			dBCluster.StorageType = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.StorageType");
			dBCluster.Port = _ctx.IntegerValue("DescribeDBClusterAttribute.DBCluster.Port");
			dBCluster.LockMode = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.LockMode");
			dBCluster.Bid = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.Bid");
			dBCluster.EngineVersion = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.EngineVersion");
			dBCluster.IsExpired = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.IsExpired");
			dBCluster.VpcCloudInstanceId = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.VpcCloudInstanceId");
			dBCluster.DBClusterId = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.DBClusterId");
			dBCluster.ConnectionString = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ConnectionString");
			dBCluster.EncryptionKey = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.EncryptionKey");
			dBCluster.DBClusterType = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.DBClusterType");
			dBCluster.CommodityCode = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.CommodityCode");
			dBCluster.ExpireTime = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ExpireTime");
			dBCluster.DBNodeStorage = _ctx.LongValue("DescribeDBClusterAttribute.DBCluster.DBNodeStorage");
			dBCluster.DBNodeClass = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.DBNodeClass");
			dBCluster.AliUid = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.AliUid");
			dBCluster.LockReason = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.LockReason");
			dBCluster.RegionId = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.RegionId");
			dBCluster.PublicPort = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.PublicPort");
			dBCluster.VSwitchId = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.VSwitchId");
			dBCluster.DBClusterStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.DBClusterStatus");
			dBCluster.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.DBClusterNetworkType");
			dBCluster.DBClusterDescription = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.DBClusterDescription");
			dBCluster.ZoneId = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ZoneId");
			dBCluster.Category = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.Category");
			dBCluster.Engine = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.Engine");
			dBCluster.SupportMysqlPort = _ctx.BooleanValue("DescribeDBClusterAttribute.DBCluster.SupportMysqlPort");
			dBCluster.SupportHttpsPort = _ctx.BooleanValue("DescribeDBClusterAttribute.DBCluster.SupportHttpsPort");
			dBCluster.ControlVersion = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ControlVersion");
			dBCluster.PublicIpAddr = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.PublicIpAddr");
			dBCluster.VpcIpAddr = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.VpcIpAddr");
			dBCluster.EngineMinorVersion = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.EngineMinorVersion");
			dBCluster.EngineLatestMinorVersion = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.EngineLatestMinorVersion");
			dBCluster.MaintainAutoType = _ctx.BooleanValue("DescribeDBClusterAttribute.DBCluster.MaintainAutoType");
			dBCluster.ExtStorageType = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ExtStorageType");
			dBCluster.ExtStorageSize = _ctx.IntegerValue("DescribeDBClusterAttribute.DBCluster.ExtStorageSize");
			dBCluster.ResourceGroupId = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ResourceGroupId");
			dBCluster.ZookeeperClass = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ZookeeperClass");
			dBCluster.AppointmentRestartTime = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.AppointmentRestartTime");
			dBCluster.ZoneIdVswitchMap = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ZoneIdVswitchMap");
			dBCluster.AvailableUpgradeMajorVersion = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.AvailableUpgradeMajorVersion");
			dBCluster.AppointmentRestartNodeTime = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.AppointmentRestartNodeTime");
			dBCluster.AppointmentRestartNodeList = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.AppointmentRestartNodeList");
			dBCluster.AppointmentElectZookeeperTime = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.AppointmentElectZookeeperTime");
			dBCluster.AppointmentElectZookeeperDisableWrite = _ctx.BooleanValue("DescribeDBClusterAttribute.DBCluster.AppointmentElectZookeeperDisableWrite");

			DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_ScaleOutStatus scaleOutStatus = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_ScaleOutStatus();
			scaleOutStatus.Progress = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ScaleOutStatus.Progress");
			scaleOutStatus.Ratio = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.ScaleOutStatus.Ratio");
			dBCluster.ScaleOutStatus = scaleOutStatus;

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag> dBCluster_tags = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAttribute.DBCluster.Tags.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag tag = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag();
				tag.Key = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeDBClusterAttribute.DBCluster.Tags["+ i +"].Value");

				dBCluster_tags.Add(tag);
			}
			dBCluster.Tags = dBCluster_tags;
			describeDBClusterAttributeResponse.DBCluster = dBCluster;
        
			return describeDBClusterAttributeResponse;
        }
    }
}
