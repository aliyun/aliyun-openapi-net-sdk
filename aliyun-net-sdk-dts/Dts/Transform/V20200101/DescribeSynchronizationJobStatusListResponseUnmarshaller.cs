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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeSynchronizationJobStatusListResponseUnmarshaller
    {
        public static DescribeSynchronizationJobStatusListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSynchronizationJobStatusListResponse describeSynchronizationJobStatusListResponse = new DescribeSynchronizationJobStatusListResponse();

			describeSynchronizationJobStatusListResponse.HttpResponse = _ctx.HttpResponse;
			describeSynchronizationJobStatusListResponse.ErrCode = _ctx.StringValue("DescribeSynchronizationJobStatusList.ErrCode");
			describeSynchronizationJobStatusListResponse.ErrMessage = _ctx.StringValue("DescribeSynchronizationJobStatusList.ErrMessage");
			describeSynchronizationJobStatusListResponse.PageNumber = _ctx.IntegerValue("DescribeSynchronizationJobStatusList.PageNumber");
			describeSynchronizationJobStatusListResponse.PageRecordCount = _ctx.IntegerValue("DescribeSynchronizationJobStatusList.PageRecordCount");
			describeSynchronizationJobStatusListResponse.RequestId = _ctx.StringValue("DescribeSynchronizationJobStatusList.RequestId");
			describeSynchronizationJobStatusListResponse.Success = _ctx.StringValue("DescribeSynchronizationJobStatusList.Success");
			describeSynchronizationJobStatusListResponse.TotalRecordCount = _ctx.LongValue("DescribeSynchronizationJobStatusList.TotalRecordCount");

			List<DescribeSynchronizationJobStatusListResponse.DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo> describeSynchronizationJobStatusListResponse_synchronizationJobListStatusList = new List<DescribeSynchronizationJobStatusListResponse.DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo>();
			for (int i = 0; i < _ctx.Length("DescribeSynchronizationJobStatusList.SynchronizationJobListStatusList.Length"); i++) {
				DescribeSynchronizationJobStatusListResponse.DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo synchronizationJobStatusInfo = new DescribeSynchronizationJobStatusListResponse.DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo();
				synchronizationJobStatusInfo.SynchronizationJobId = _ctx.StringValue("DescribeSynchronizationJobStatusList.SynchronizationJobListStatusList["+ i +"].SynchronizationJobId");

				List<DescribeSynchronizationJobStatusListResponse.DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo.DescribeSynchronizationJobStatusList_SynchronizationDirectionInfo> synchronizationJobStatusInfo_synchronizationDirectionInfoList = new List<DescribeSynchronizationJobStatusListResponse.DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo.DescribeSynchronizationJobStatusList_SynchronizationDirectionInfo>();
				for (int j = 0; j < _ctx.Length("DescribeSynchronizationJobStatusList.SynchronizationJobListStatusList["+ i +"].SynchronizationDirectionInfoList.Length"); j++) {
					DescribeSynchronizationJobStatusListResponse.DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo.DescribeSynchronizationJobStatusList_SynchronizationDirectionInfo synchronizationDirectionInfo = new DescribeSynchronizationJobStatusListResponse.DescribeSynchronizationJobStatusList_SynchronizationJobStatusInfo.DescribeSynchronizationJobStatusList_SynchronizationDirectionInfo();
					synchronizationDirectionInfo.Checkpoint = _ctx.StringValue("DescribeSynchronizationJobStatusList.SynchronizationJobListStatusList["+ i +"].SynchronizationDirectionInfoList["+ j +"].Checkpoint");
					synchronizationDirectionInfo.Status = _ctx.StringValue("DescribeSynchronizationJobStatusList.SynchronizationJobListStatusList["+ i +"].SynchronizationDirectionInfoList["+ j +"].Status");
					synchronizationDirectionInfo.SynchronizationDirection = _ctx.StringValue("DescribeSynchronizationJobStatusList.SynchronizationJobListStatusList["+ i +"].SynchronizationDirectionInfoList["+ j +"].SynchronizationDirection");

					synchronizationJobStatusInfo_synchronizationDirectionInfoList.Add(synchronizationDirectionInfo);
				}
				synchronizationJobStatusInfo.SynchronizationDirectionInfoList = synchronizationJobStatusInfo_synchronizationDirectionInfoList;

				describeSynchronizationJobStatusListResponse_synchronizationJobListStatusList.Add(synchronizationJobStatusInfo);
			}
			describeSynchronizationJobStatusListResponse.SynchronizationJobListStatusList = describeSynchronizationJobStatusListResponse_synchronizationJobListStatusList;
        
			return describeSynchronizationJobStatusListResponse;
        }
    }
}
