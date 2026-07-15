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
    public class ReadSchedulerxDesignateDetailResponseUnmarshaller
    {
        public static ReadSchedulerxDesignateDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReadSchedulerxDesignateDetailResponse readSchedulerxDesignateDetailResponse = new ReadSchedulerxDesignateDetailResponse();

			readSchedulerxDesignateDetailResponse.HttpResponse = _ctx.HttpResponse;
			readSchedulerxDesignateDetailResponse.Message = _ctx.StringValue("ReadSchedulerxDesignateDetail.Message");
			readSchedulerxDesignateDetailResponse.RequestId = _ctx.StringValue("ReadSchedulerxDesignateDetail.RequestId");
			readSchedulerxDesignateDetailResponse.Code = _ctx.IntegerValue("ReadSchedulerxDesignateDetail.Code");
			readSchedulerxDesignateDetailResponse.Success = _ctx.BooleanValue("ReadSchedulerxDesignateDetail.Success");

			ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_AccessDeniedDetail accessDeniedDetail = new ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_AccessDeniedDetail();
			accessDeniedDetail.PolicyType = _ctx.StringValue("ReadSchedulerxDesignateDetail.AccessDeniedDetail.PolicyType");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("ReadSchedulerxDesignateDetail.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("ReadSchedulerxDesignateDetail.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("ReadSchedulerxDesignateDetail.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("ReadSchedulerxDesignateDetail.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("ReadSchedulerxDesignateDetail.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.AuthAction = _ctx.StringValue("ReadSchedulerxDesignateDetail.AccessDeniedDetail.AuthAction");
			readSchedulerxDesignateDetailResponse.AccessDeniedDetail = accessDeniedDetail;

			ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_Data data = new ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_Data();

			List<ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_Data.ReadSchedulerxDesignateDetail_DesignateDetailVo> data_designateDetailVos = new List<ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_Data.ReadSchedulerxDesignateDetail_DesignateDetailVo>();
			for (int i = 0; i < _ctx.Length("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos.Length"); i++) {
				ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_Data.ReadSchedulerxDesignateDetail_DesignateDetailVo designateDetailVo = new ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_Data.ReadSchedulerxDesignateDetail_DesignateDetailVo();
				designateDetailVo._Checked = _ctx.BooleanValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Checked");
				designateDetailVo.Version = _ctx.StringValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Version");
				designateDetailVo.Size = _ctx.IntegerValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Size");
				designateDetailVo.Busy = _ctx.StringValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Busy");
				designateDetailVo.Offline = _ctx.BooleanValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Offline");
				designateDetailVo.Starter = _ctx.StringValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Starter");
				designateDetailVo.Key = _ctx.StringValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Key");

				ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_Data.ReadSchedulerxDesignateDetail_DesignateDetailVo.ReadSchedulerxDesignateDetail_Metrics metrics = new ReadSchedulerxDesignateDetailResponse.ReadSchedulerxDesignateDetail_Data.ReadSchedulerxDesignateDetail_DesignateDetailVo.ReadSchedulerxDesignateDetail_Metrics();
				metrics.SharePoolAvailableSize = _ctx.IntegerValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.SharePoolAvailableSize");
				metrics.Heap1Usage = _ctx.DoubleValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.Heap1Usage");
				metrics.DiskUsage = _ctx.DoubleValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.DiskUsage");
				metrics.CpuProcessors = _ctx.IntegerValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.CpuProcessors");
				metrics.Heap1Used = _ctx.DoubleValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.Heap1Used");
				metrics.CpuLoad1 = _ctx.DoubleValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.CpuLoad1");
				metrics.CpuLoad5 = _ctx.DoubleValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.CpuLoad5");
				metrics.ExecCount = _ctx.LongValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.ExecCount");
				metrics.SharePoolQueueSize = _ctx.IntegerValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.SharePoolQueueSize");
				metrics.HeapMax = _ctx.IntegerValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.HeapMax");
				metrics.DiskUsed = _ctx.IntegerValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.DiskUsed");
				metrics.DiskMax = _ctx.IntegerValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.DiskMax");
				metrics.Heap5Usage = _ctx.DoubleValue("ReadSchedulerxDesignateDetail.Data.DesignateDetailVos["+ i +"].Metrics.Heap5Usage");
				designateDetailVo.Metrics = metrics;

				data_designateDetailVos.Add(designateDetailVo);
			}
			data.DesignateDetailVos = data_designateDetailVos;
			readSchedulerxDesignateDetailResponse.Data = data;
        
			return readSchedulerxDesignateDetailResponse;
        }
    }
}
