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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class ReadSchedulerxDesignateInfoResponseUnmarshaller
    {
        public static ReadSchedulerxDesignateInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReadSchedulerxDesignateInfoResponse readSchedulerxDesignateInfoResponse = new ReadSchedulerxDesignateInfoResponse();

			readSchedulerxDesignateInfoResponse.HttpResponse = _ctx.HttpResponse;
			readSchedulerxDesignateInfoResponse.Code = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Code");
			readSchedulerxDesignateInfoResponse.Message = _ctx.StringValue("ReadSchedulerxDesignateInfo.Message");
			readSchedulerxDesignateInfoResponse.RequestId = _ctx.StringValue("ReadSchedulerxDesignateInfo.RequestId");
			readSchedulerxDesignateInfoResponse.Success = _ctx.BooleanValue("ReadSchedulerxDesignateInfo.Success");

			ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_Data data = new ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_Data();
			data.DesignateType = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Data.DesignateType");
			data.Transferable = _ctx.BooleanValue("ReadSchedulerxDesignateInfo.Data.Transferable");

			List<ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_Data.ReadSchedulerxDesignateInfo_DesignateDetailVo> data_designateDetailVos = new List<ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_Data.ReadSchedulerxDesignateInfo_DesignateDetailVo>();
			for (int i = 0; i < _ctx.Length("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos.Length"); i++) {
				ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_Data.ReadSchedulerxDesignateInfo_DesignateDetailVo designateDetailVo = new ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_Data.ReadSchedulerxDesignateInfo_DesignateDetailVo();
				designateDetailVo._Checked = _ctx.BooleanValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Checked");
				designateDetailVo.Version = _ctx.StringValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Version");
				designateDetailVo.Size = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Size");
				designateDetailVo.Busy = _ctx.StringValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Busy");
				designateDetailVo.Offline = _ctx.BooleanValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Offline");
				designateDetailVo.Starter = _ctx.StringValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Starter");
				designateDetailVo.Key = _ctx.StringValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Key");

				ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_Data.ReadSchedulerxDesignateInfo_DesignateDetailVo.ReadSchedulerxDesignateInfo_Metrics metrics = new ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_Data.ReadSchedulerxDesignateInfo_DesignateDetailVo.ReadSchedulerxDesignateInfo_Metrics();
				metrics.SharePoolAvailableSize = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.SharePoolAvailableSize");
				metrics.Heap1Usage = _ctx.DoubleValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.Heap1Usage");
				metrics.DiskUsage = _ctx.DoubleValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.DiskUsage");
				metrics.CpuProcessors = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.CpuProcessors");
				metrics.Heap1Used = _ctx.DoubleValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.Heap1Used");
				metrics.CpuLoad1 = _ctx.DoubleValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.CpuLoad1");
				metrics.CpuLoad5 = _ctx.DoubleValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.CpuLoad5");
				metrics.ExecCount = _ctx.LongValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.ExecCount");
				metrics.SharePoolQueueSize = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.SharePoolQueueSize");
				metrics.HeapMax = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.HeapMax");
				metrics.DiskUsed = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.DiskUsed");
				metrics.DiskMax = _ctx.IntegerValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.DiskMax");
				metrics.Heap5Usage = _ctx.DoubleValue("ReadSchedulerxDesignateInfo.Data.DesignateDetailVos["+ i +"].Metrics.Heap5Usage");
				designateDetailVo.Metrics = metrics;

				data_designateDetailVos.Add(designateDetailVo);
			}
			data.DesignateDetailVos = data_designateDetailVos;
			readSchedulerxDesignateInfoResponse.Data = data;

			ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_AccessDeniedDetail accessDeniedDetail = new ReadSchedulerxDesignateInfoResponse.ReadSchedulerxDesignateInfo_AccessDeniedDetail();
			accessDeniedDetail.AuthAction = _ctx.StringValue("ReadSchedulerxDesignateInfo.AccessDeniedDetail.AuthAction");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("ReadSchedulerxDesignateInfo.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("ReadSchedulerxDesignateInfo.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("ReadSchedulerxDesignateInfo.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("ReadSchedulerxDesignateInfo.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("ReadSchedulerxDesignateInfo.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.PolicyType = _ctx.StringValue("ReadSchedulerxDesignateInfo.AccessDeniedDetail.PolicyType");
			readSchedulerxDesignateInfoResponse.AccessDeniedDetail = accessDeniedDetail;
        
			return readSchedulerxDesignateInfoResponse;
        }
    }
}
