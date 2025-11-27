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
    public class GetRegionalInstanceConfigResponseUnmarshaller
    {
        public static GetRegionalInstanceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRegionalInstanceConfigResponse getRegionalInstanceConfigResponse = new GetRegionalInstanceConfigResponse();

			getRegionalInstanceConfigResponse.HttpResponse = _ctx.HttpResponse;
			getRegionalInstanceConfigResponse.RequestId = _ctx.StringValue("GetRegionalInstanceConfig.RequestId");

			GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result result = new GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result();
			result.SpecInfoMap = _ctx.StringValue("GetRegionalInstanceConfig.Result.specInfoMap");

			List<string> result_clientSpecs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.ClientSpecs.Length"); i++) {
				result_clientSpecs.Add(_ctx.StringValue("GetRegionalInstanceConfig.Result.ClientSpecs["+ i +"]"));
			}
			result.ClientSpecs = result_clientSpecs;

			List<string> result_dataNodeSpecs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.DataNodeSpecs.Length"); i++) {
				result_dataNodeSpecs.Add(_ctx.StringValue("GetRegionalInstanceConfig.Result.DataNodeSpecs["+ i +"]"));
			}
			result.DataNodeSpecs = result_dataNodeSpecs;

			List<string> result_kibanaSpecs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.KibanaSpecs.Length"); i++) {
				result_kibanaSpecs.Add(_ctx.StringValue("GetRegionalInstanceConfig.Result.KibanaSpecs["+ i +"]"));
			}
			result.KibanaSpecs = result_kibanaSpecs;

			List<string> result_masterSpecs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.MasterSpecs.Length"); i++) {
				result_masterSpecs.Add(_ctx.StringValue("GetRegionalInstanceConfig.Result.MasterSpecs["+ i +"]"));
			}
			result.MasterSpecs = result_masterSpecs;

			List<string> result_versions = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.Versions.Length"); i++) {
				result_versions.Add(_ctx.StringValue("GetRegionalInstanceConfig.Result.Versions["+ i +"]"));
			}
			result.Versions = result_versions;

			List<string> result_masterAmountRange = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.MasterAmountRange.Length"); i++) {
				result_masterAmountRange.Add(_ctx.StringValue("GetRegionalInstanceConfig.Result.MasterAmountRange["+ i +"]"));
			}
			result.MasterAmountRange = result_masterAmountRange;

			GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_ClientNodeAmountRange clientNodeAmountRange = new GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_ClientNodeAmountRange();
			clientNodeAmountRange.MinAmount = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.ClientNodeAmountRange.minAmount");
			clientNodeAmountRange.MaxAmount = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.ClientNodeAmountRange.maxAmount");
			result.ClientNodeAmountRange = clientNodeAmountRange;

			GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeAmountRange dataNodeAmountRange = new GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeAmountRange();
			dataNodeAmountRange.MinAmount = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.DataNodeAmountRange.minAmount");
			dataNodeAmountRange.MaxAmount = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.DataNodeAmountRange.maxAmount");
			result.DataNodeAmountRange = dataNodeAmountRange;

			List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_MasterDiskListItem> result_masterDiskList = new List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_MasterDiskListItem>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.MasterDiskList.Length"); i++) {
				GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_MasterDiskListItem masterDiskListItem = new GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_MasterDiskListItem();
				masterDiskListItem.MinSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.MasterDiskList["+ i +"].minSize");
				masterDiskListItem.MaxSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.MasterDiskList["+ i +"].maxSize");
				masterDiskListItem.ScaleLimit = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.MasterDiskList["+ i +"].scaleLimit");
				masterDiskListItem.DiskType = _ctx.StringValue("GetRegionalInstanceConfig.Result.MasterDiskList["+ i +"].diskType");

				List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_MasterDiskListItem.GetRegionalInstanceConfig_SubClassificationConfinesItem> masterDiskListItem_subClassificationConfines = new List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_MasterDiskListItem.GetRegionalInstanceConfig_SubClassificationConfinesItem>();
				for (int j = 0; j < _ctx.Length("GetRegionalInstanceConfig.Result.MasterDiskList["+ i +"].SubClassificationConfines.Length"); j++) {
					GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_MasterDiskListItem.GetRegionalInstanceConfig_SubClassificationConfinesItem subClassificationConfinesItem = new GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_MasterDiskListItem.GetRegionalInstanceConfig_SubClassificationConfinesItem();
					subClassificationConfinesItem.MinSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.MasterDiskList["+ i +"].SubClassificationConfines["+ j +"].minSize");
					subClassificationConfinesItem.MaxSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.MasterDiskList["+ i +"].SubClassificationConfines["+ j +"].maxSize");
					subClassificationConfinesItem.PerformanceLevel = _ctx.StringValue("GetRegionalInstanceConfig.Result.MasterDiskList["+ i +"].SubClassificationConfines["+ j +"].performanceLevel");

					masterDiskListItem_subClassificationConfines.Add(subClassificationConfinesItem);
				}
				masterDiskListItem.SubClassificationConfines = masterDiskListItem_subClassificationConfines;

				result_masterDiskList.Add(masterDiskListItem);
			}
			result.MasterDiskList = result_masterDiskList;

			List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_ClientNodeDiskListItem> result_clientNodeDiskList = new List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_ClientNodeDiskListItem>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.ClientNodeDiskList.Length"); i++) {
				GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_ClientNodeDiskListItem clientNodeDiskListItem = new GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_ClientNodeDiskListItem();
				clientNodeDiskListItem.MinSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.ClientNodeDiskList["+ i +"].minSize");
				clientNodeDiskListItem.MaxSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.ClientNodeDiskList["+ i +"].maxSize");
				clientNodeDiskListItem.ScaleLimit = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.ClientNodeDiskList["+ i +"].scaleLimit");
				clientNodeDiskListItem.DiskType = _ctx.StringValue("GetRegionalInstanceConfig.Result.ClientNodeDiskList["+ i +"].diskType");

				result_clientNodeDiskList.Add(clientNodeDiskListItem);
			}
			result.ClientNodeDiskList = result_clientNodeDiskList;

			List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeDiskListItem> result_dataNodeDiskList = new List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeDiskListItem>();
			for (int i = 0; i < _ctx.Length("GetRegionalInstanceConfig.Result.DataNodeDiskList.Length"); i++) {
				GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeDiskListItem dataNodeDiskListItem = new GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeDiskListItem();
				dataNodeDiskListItem.MinSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].minSize");
				dataNodeDiskListItem.MaxSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].maxSize");
				dataNodeDiskListItem.ScaleLimit = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].scaleLimit");
				dataNodeDiskListItem.DiskType = _ctx.StringValue("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].diskType");

				List<string> dataNodeDiskListItem_valueLimitSet = new List<string>();
				for (int j = 0; j < _ctx.Length("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].ValueLimitSet.Length"); j++) {
					dataNodeDiskListItem_valueLimitSet.Add(_ctx.StringValue("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].ValueLimitSet["+ j +"]"));
				}
				dataNodeDiskListItem.ValueLimitSet = dataNodeDiskListItem_valueLimitSet;

				List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeDiskListItem.GetRegionalInstanceConfig_SubClassificationConfinesItem2> dataNodeDiskListItem_subClassificationConfines1 = new List<GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeDiskListItem.GetRegionalInstanceConfig_SubClassificationConfinesItem2>();
				for (int j = 0; j < _ctx.Length("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].SubClassificationConfines.Length"); j++) {
					GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeDiskListItem.GetRegionalInstanceConfig_SubClassificationConfinesItem2 subClassificationConfinesItem2 = new GetRegionalInstanceConfigResponse.GetRegionalInstanceConfig_Result.GetRegionalInstanceConfig_DataNodeDiskListItem.GetRegionalInstanceConfig_SubClassificationConfinesItem2();
					subClassificationConfinesItem2.MinSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].SubClassificationConfines["+ j +"].minSize");
					subClassificationConfinesItem2.MaxSize = _ctx.IntegerValue("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].SubClassificationConfines["+ j +"].maxSize");
					subClassificationConfinesItem2.PerformanceLevel = _ctx.StringValue("GetRegionalInstanceConfig.Result.DataNodeDiskList["+ i +"].SubClassificationConfines["+ j +"].performanceLevel");

					dataNodeDiskListItem_subClassificationConfines1.Add(subClassificationConfinesItem2);
				}
				dataNodeDiskListItem.SubClassificationConfines1 = dataNodeDiskListItem_subClassificationConfines1;

				result_dataNodeDiskList.Add(dataNodeDiskListItem);
			}
			result.DataNodeDiskList = result_dataNodeDiskList;
			getRegionalInstanceConfigResponse.Result = result;
        
			return getRegionalInstanceConfigResponse;
        }
    }
}
