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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class GetRegionConfigurationResponseUnmarshaller
    {
        public static GetRegionConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRegionConfigurationResponse getRegionConfigurationResponse = new GetRegionConfigurationResponse();

			getRegionConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			getRegionConfigurationResponse.RequestId = _ctx.StringValue("GetRegionConfiguration.RequestId");

			GetRegionConfigurationResponse.GetRegionConfiguration_Result result = new GetRegionConfigurationResponse.GetRegionConfiguration_Result();
			result.Env = _ctx.StringValue("GetRegionConfiguration.Result.env");
			result.RegionId = _ctx.StringValue("GetRegionConfiguration.Result.regionId");
			result.CreateUrl = _ctx.StringValue("GetRegionConfiguration.Result.createUrl");

			List<string> result_zones = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.Zones.Length"); i++) {
				result_zones.Add(_ctx.StringValue("GetRegionConfiguration.Result.Zones["+ i +"]"));
			}
			result.Zones = result_zones;

			List<string> result_esVersions = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.EsVersions.Length"); i++) {
				result_esVersions.Add(_ctx.StringValue("GetRegionConfiguration.Result.EsVersions["+ i +"]"));
			}
			result.EsVersions = result_esVersions;

			List<string> result_masterSpec = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.MasterSpec.Length"); i++) {
				result_masterSpec.Add(_ctx.StringValue("GetRegionConfiguration.Result.MasterSpec["+ i +"]"));
			}
			result.MasterSpec = result_masterSpec;

			List<string> result_clientNodeSpec = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.ClientNodeSpec.Length"); i++) {
				result_clientNodeSpec.Add(_ctx.StringValue("GetRegionConfiguration.Result.ClientNodeSpec["+ i +"]"));
			}
			result.ClientNodeSpec = result_clientNodeSpec;

			List<string> result_instanceSupportNodes = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.InstanceSupportNodes.Length"); i++) {
				result_instanceSupportNodes.Add(_ctx.StringValue("GetRegionConfiguration.Result.InstanceSupportNodes["+ i +"]"));
			}
			result.InstanceSupportNodes = result_instanceSupportNodes;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Node node = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Node();
			node.MinAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.Node.minAmount");
			node.MaxAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.Node.maxAmount");
			result.Node = node;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_JvmConfine jvmConfine = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_JvmConfine();
			jvmConfine.Memory = _ctx.IntegerValue("GetRegionConfiguration.Result.JvmConfine.memory");

			List<string> jvmConfine_supportGcs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.JvmConfine.SupportGcs.Length"); i++) {
				jvmConfine_supportGcs.Add(_ctx.StringValue("GetRegionConfiguration.Result.JvmConfine.SupportGcs["+ i +"]"));
			}
			jvmConfine.SupportGcs = jvmConfine_supportGcs;

			List<string> jvmConfine_supportEsVersions = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.JvmConfine.SupportEsVersions.Length"); i++) {
				jvmConfine_supportEsVersions.Add(_ctx.StringValue("GetRegionConfiguration.Result.JvmConfine.SupportEsVersions["+ i +"]"));
			}
			jvmConfine.SupportEsVersions = jvmConfine_supportEsVersions;
			result.JvmConfine = jvmConfine;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ClientNodeAmountRange clientNodeAmountRange = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ClientNodeAmountRange();
			clientNodeAmountRange.MinAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.ClientNodeAmountRange.minAmount");
			clientNodeAmountRange.MaxAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.ClientNodeAmountRange.maxAmount");
			result.ClientNodeAmountRange = clientNodeAmountRange;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties warmNodeProperties = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties();

			List<string> warmNodeProperties_spec = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.WarmNodeProperties.Spec.Length"); i++) {
				warmNodeProperties_spec.Add(_ctx.StringValue("GetRegionConfiguration.Result.WarmNodeProperties.Spec["+ i +"]"));
			}
			warmNodeProperties.Spec = warmNodeProperties_spec;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_AmountRange amountRange = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_AmountRange();
			amountRange.MaxAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.AmountRange.maxAmount");
			amountRange.MinAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.AmountRange.minAmount");
			warmNodeProperties.AmountRange = amountRange;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_Disk1> warmNodeProperties_diskList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_Disk1>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.WarmNodeProperties.DiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_Disk1 disk1 = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_Disk1();
				disk1.DiskType = _ctx.StringValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].diskType");
				disk1.MaxSize = _ctx.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].maxSize");
				disk1.MinSize = _ctx.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].minSize");
				disk1.ScaleLimit = _ctx.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].scaleLimit");
				disk1.DiskEncryption = _ctx.BooleanValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].diskEncryption");

				List<string> disk1_valueLimitSet2 = new List<string>();
				for (int j = 0; j < _ctx.Length("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].ValueLimitSet.Length"); j++) {
					disk1_valueLimitSet2.Add(_ctx.StringValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].ValueLimitSet["+ j +"]"));
				}
				disk1.ValueLimitSet2 = disk1_valueLimitSet2;

				warmNodeProperties_diskList.Add(disk1);
			}
			warmNodeProperties.DiskList = warmNodeProperties_diskList;
			result.WarmNodeProperties = warmNodeProperties;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_KibanaNodeProperties kibanaNodeProperties = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_KibanaNodeProperties();

			List<string> kibanaNodeProperties_spec3 = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.KibanaNodeProperties.Spec.Length"); i++) {
				kibanaNodeProperties_spec3.Add(_ctx.StringValue("GetRegionConfiguration.Result.KibanaNodeProperties.Spec["+ i +"]"));
			}
			kibanaNodeProperties.Spec3 = kibanaNodeProperties_spec3;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_KibanaNodeProperties.GetRegionConfiguration_AmountRange4 amountRange4 = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_KibanaNodeProperties.GetRegionConfiguration_AmountRange4();
			amountRange4.MaxAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.KibanaNodeProperties.AmountRange.maxAmount");
			amountRange4.MinAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.KibanaNodeProperties.AmountRange.minAmount");
			kibanaNodeProperties.AmountRange4 = amountRange4;
			result.KibanaNodeProperties = kibanaNodeProperties;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ElasticNodeProperties elasticNodeProperties = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ElasticNodeProperties();

			List<string> elasticNodeProperties_spec5 = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.ElasticNodeProperties.Spec.Length"); i++) {
				elasticNodeProperties_spec5.Add(_ctx.StringValue("GetRegionConfiguration.Result.ElasticNodeProperties.Spec["+ i +"]"));
			}
			elasticNodeProperties.Spec5 = elasticNodeProperties_spec5;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ElasticNodeProperties.GetRegionConfiguration_AmountRange6 amountRange6 = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ElasticNodeProperties.GetRegionConfiguration_AmountRange6();
			amountRange6.MaxAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.ElasticNodeProperties.AmountRange.maxAmount");
			amountRange6.MinAmount = _ctx.IntegerValue("GetRegionConfiguration.Result.ElasticNodeProperties.AmountRange.minAmount");
			elasticNodeProperties.AmountRange6 = amountRange6;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ElasticNodeProperties.GetRegionConfiguration_Disk8> elasticNodeProperties_diskList7 = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ElasticNodeProperties.GetRegionConfiguration_Disk8>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.ElasticNodeProperties.DiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ElasticNodeProperties.GetRegionConfiguration_Disk8 disk8 = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ElasticNodeProperties.GetRegionConfiguration_Disk8();
				disk8.DiskType = _ctx.StringValue("GetRegionConfiguration.Result.ElasticNodeProperties.DiskList["+ i +"].diskType");
				disk8.MaxSize = _ctx.IntegerValue("GetRegionConfiguration.Result.ElasticNodeProperties.DiskList["+ i +"].maxSize");
				disk8.MinSize = _ctx.IntegerValue("GetRegionConfiguration.Result.ElasticNodeProperties.DiskList["+ i +"].minSize");
				disk8.ScaleLimit = _ctx.IntegerValue("GetRegionConfiguration.Result.ElasticNodeProperties.DiskList["+ i +"].scaleLimit");
				disk8.DiskEncryption = _ctx.BooleanValue("GetRegionConfiguration.Result.ElasticNodeProperties.DiskList["+ i +"].diskEncryption");

				List<string> disk8_valueLimitSet9 = new List<string>();
				for (int j = 0; j < _ctx.Length("GetRegionConfiguration.Result.ElasticNodeProperties.DiskList["+ i +"].ValueLimitSet.Length"); j++) {
					disk8_valueLimitSet9.Add(_ctx.StringValue("GetRegionConfiguration.Result.ElasticNodeProperties.DiskList["+ i +"].ValueLimitSet["+ j +"]"));
				}
				disk8.ValueLimitSet9 = disk8_valueLimitSet9;

				elasticNodeProperties_diskList7.Add(disk8);
			}
			elasticNodeProperties.DiskList7 = elasticNodeProperties_diskList7;
			result.ElasticNodeProperties = elasticNodeProperties;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_DataDiskListItem> result_dataDiskList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_DataDiskListItem>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.DataDiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_DataDiskListItem dataDiskListItem = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_DataDiskListItem();
				dataDiskListItem.DiskType = _ctx.StringValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].diskType");
				dataDiskListItem.MinSize = _ctx.IntegerValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].minSize");
				dataDiskListItem.MaxSize = _ctx.IntegerValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].maxSize");
				dataDiskListItem.ScaleLimit = _ctx.IntegerValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].scaleLimit");

				List<string> dataDiskListItem_valueLimitSet = new List<string>();
				for (int j = 0; j < _ctx.Length("GetRegionConfiguration.Result.DataDiskList["+ i +"].ValueLimitSet.Length"); j++) {
					dataDiskListItem_valueLimitSet.Add(_ctx.StringValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].ValueLimitSet["+ j +"]"));
				}
				dataDiskListItem.ValueLimitSet = dataDiskListItem_valueLimitSet;

				result_dataDiskList.Add(dataDiskListItem);
			}
			result.DataDiskList = result_dataDiskList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_EsVersionsLatestListItem> result_esVersionsLatestList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_EsVersionsLatestListItem>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.EsVersionsLatestList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_EsVersionsLatestListItem esVersionsLatestListItem = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_EsVersionsLatestListItem();
				esVersionsLatestListItem.Key = _ctx.StringValue("GetRegionConfiguration.Result.EsVersionsLatestList["+ i +"].key");
				esVersionsLatestListItem._Value = _ctx.StringValue("GetRegionConfiguration.Result.EsVersionsLatestList["+ i +"].value");

				result_esVersionsLatestList.Add(esVersionsLatestListItem);
			}
			result.EsVersionsLatestList = result_esVersionsLatestList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_NodeSpecListItem> result_nodeSpecList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_NodeSpecListItem>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.NodeSpecList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_NodeSpecListItem nodeSpecListItem = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_NodeSpecListItem();
				nodeSpecListItem.CpuCount = _ctx.IntegerValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].cpuCount");
				nodeSpecListItem.MemorySize = _ctx.IntegerValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].memorySize");
				nodeSpecListItem.Enable = _ctx.BooleanValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].enable");
				nodeSpecListItem.Spec = _ctx.StringValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].spec");
				nodeSpecListItem.DiskType = _ctx.StringValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].diskType");
				nodeSpecListItem.Disk = _ctx.IntegerValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].disk");
				nodeSpecListItem.SpecGroupType = _ctx.StringValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].specGroupType");

				result_nodeSpecList.Add(nodeSpecListItem);
			}
			result.NodeSpecList = result_nodeSpecList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk> result_clientNodeDiskList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.ClientNodeDiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk disk = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk();
				disk.DiskType = _ctx.StringValue("GetRegionConfiguration.Result.ClientNodeDiskList["+ i +"].diskType");
				disk.MinSize = _ctx.IntegerValue("GetRegionConfiguration.Result.ClientNodeDiskList["+ i +"].minSize");
				disk.MaxSize = _ctx.IntegerValue("GetRegionConfiguration.Result.ClientNodeDiskList["+ i +"].maxSize");
				disk.ScaleLimit = _ctx.IntegerValue("GetRegionConfiguration.Result.ClientNodeDiskList["+ i +"].scaleLimit");

				result_clientNodeDiskList.Add(disk);
			}
			result.ClientNodeDiskList = result_clientNodeDiskList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk> result_masterDiskList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.MasterDiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk disk = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk();
				disk.DiskType = _ctx.StringValue("GetRegionConfiguration.Result.MasterDiskList["+ i +"].diskType");
				disk.MinSize = _ctx.IntegerValue("GetRegionConfiguration.Result.MasterDiskList["+ i +"].minSize");
				disk.MaxSize = _ctx.IntegerValue("GetRegionConfiguration.Result.MasterDiskList["+ i +"].maxSize");
				disk.ScaleLimit = _ctx.IntegerValue("GetRegionConfiguration.Result.MasterDiskList["+ i +"].scaleLimit");

				result_masterDiskList.Add(disk);
			}
			result.MasterDiskList = result_masterDiskList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_CategoryEntity> result_supportVersions = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_CategoryEntity>();
			for (int i = 0; i < _ctx.Length("GetRegionConfiguration.Result.SupportVersions.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_CategoryEntity categoryEntity = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_CategoryEntity();
				categoryEntity.InstanceCategory = _ctx.StringValue("GetRegionConfiguration.Result.SupportVersions["+ i +"].instanceCategory");

				List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_CategoryEntity.GetRegionConfiguration_VersionEntity> categoryEntity_supportVersionList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_CategoryEntity.GetRegionConfiguration_VersionEntity>();
				for (int j = 0; j < _ctx.Length("GetRegionConfiguration.Result.SupportVersions["+ i +"].SupportVersionList.Length"); j++) {
					GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_CategoryEntity.GetRegionConfiguration_VersionEntity versionEntity = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_CategoryEntity.GetRegionConfiguration_VersionEntity();
					versionEntity.Key = _ctx.StringValue("GetRegionConfiguration.Result.SupportVersions["+ i +"].SupportVersionList["+ j +"].key");
					versionEntity._Value = _ctx.StringValue("GetRegionConfiguration.Result.SupportVersions["+ i +"].SupportVersionList["+ j +"].value");

					categoryEntity_supportVersionList.Add(versionEntity);
				}
				categoryEntity.SupportVersionList = categoryEntity_supportVersionList;

				result_supportVersions.Add(categoryEntity);
			}
			result.SupportVersions = result_supportVersions;
			getRegionConfigurationResponse.Result = result;
        
			return getRegionConfigurationResponse;
        }
    }
}
