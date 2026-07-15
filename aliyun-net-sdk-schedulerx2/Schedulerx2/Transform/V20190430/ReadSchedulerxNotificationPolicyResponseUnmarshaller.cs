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
    public class ReadSchedulerxNotificationPolicyResponseUnmarshaller
    {
        public static ReadSchedulerxNotificationPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReadSchedulerxNotificationPolicyResponse readSchedulerxNotificationPolicyResponse = new ReadSchedulerxNotificationPolicyResponse();

			readSchedulerxNotificationPolicyResponse.HttpResponse = _ctx.HttpResponse;
			readSchedulerxNotificationPolicyResponse.Message = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Message");
			readSchedulerxNotificationPolicyResponse.RequestId = _ctx.StringValue("ReadSchedulerxNotificationPolicy.RequestId");
			readSchedulerxNotificationPolicyResponse.Code = _ctx.IntegerValue("ReadSchedulerxNotificationPolicy.Code");
			readSchedulerxNotificationPolicyResponse.Success = _ctx.BooleanValue("ReadSchedulerxNotificationPolicy.Success");

			ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_AccessDeniedDetail accessDeniedDetail = new ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_AccessDeniedDetail();
			accessDeniedDetail.PolicyType = _ctx.StringValue("ReadSchedulerxNotificationPolicy.AccessDeniedDetail.PolicyType");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("ReadSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("ReadSchedulerxNotificationPolicy.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("ReadSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("ReadSchedulerxNotificationPolicy.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("ReadSchedulerxNotificationPolicy.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.AuthAction = _ctx.StringValue("ReadSchedulerxNotificationPolicy.AccessDeniedDetail.AuthAction");
			readSchedulerxNotificationPolicyResponse.AccessDeniedDetail = accessDeniedDetail;

			ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data data = new ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data();
			data.NextToken = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.NextToken");
			data.Total = _ctx.LongValue("ReadSchedulerxNotificationPolicy.Data.Total");
			data.MaxResults = _ctx.IntegerValue("ReadSchedulerxNotificationPolicy.Data.MaxResults");

			List<ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data.ReadSchedulerxNotificationPolicy_Record> data_records = new List<ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data.ReadSchedulerxNotificationPolicy_Record>();
			for (int i = 0; i < _ctx.Length("ReadSchedulerxNotificationPolicy.Data.Records.Length"); i++) {
				ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data.ReadSchedulerxNotificationPolicy_Record record = new ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data.ReadSchedulerxNotificationPolicy_Record();
				record.Description = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].Description");
				record.Updater = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].Updater");
				record.PolicyName = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].PolicyName");
				record.CreateTime = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].CreateTime");
				record.UpdateTime = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].UpdateTime");
				record.Creator = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].Creator");
				record.ChannelTimeRange = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].ChannelTimeRange");

				List<ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data.ReadSchedulerxNotificationPolicy_Record.ReadSchedulerxNotificationPolicy_ReferencedApp> record_referenceApps = new List<ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data.ReadSchedulerxNotificationPolicy_Record.ReadSchedulerxNotificationPolicy_ReferencedApp>();
				for (int j = 0; j < _ctx.Length("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].ReferenceApps.Length"); j++) {
					ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data.ReadSchedulerxNotificationPolicy_Record.ReadSchedulerxNotificationPolicy_ReferencedApp referencedApp = new ReadSchedulerxNotificationPolicyResponse.ReadSchedulerxNotificationPolicy_Data.ReadSchedulerxNotificationPolicy_Record.ReadSchedulerxNotificationPolicy_ReferencedApp();
					referencedApp.NamespaceName = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].ReferenceApps["+ j +"].NamespaceName");
					referencedApp.NamespaceUid = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].ReferenceApps["+ j +"].NamespaceUid");
					referencedApp.AppGroupId = _ctx.LongValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].ReferenceApps["+ j +"].AppGroupId");
					referencedApp.GroupId = _ctx.StringValue("ReadSchedulerxNotificationPolicy.Data.Records["+ i +"].ReferenceApps["+ j +"].GroupId");

					record_referenceApps.Add(referencedApp);
				}
				record.ReferenceApps = record_referenceApps;

				data_records.Add(record);
			}
			data.Records = data_records;
			readSchedulerxNotificationPolicyResponse.Data = data;
        
			return readSchedulerxNotificationPolicyResponse;
        }
    }
}
