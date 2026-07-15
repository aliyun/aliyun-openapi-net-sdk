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
    public class ManageSchedulerxCalendarResponseUnmarshaller
    {
        public static ManageSchedulerxCalendarResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ManageSchedulerxCalendarResponse manageSchedulerxCalendarResponse = new ManageSchedulerxCalendarResponse();

			manageSchedulerxCalendarResponse.HttpResponse = _ctx.HttpResponse;
			manageSchedulerxCalendarResponse.Message = _ctx.StringValue("ManageSchedulerxCalendar.Message");
			manageSchedulerxCalendarResponse.RequestId = _ctx.StringValue("ManageSchedulerxCalendar.RequestId");
			manageSchedulerxCalendarResponse.Code = _ctx.IntegerValue("ManageSchedulerxCalendar.Code");
			manageSchedulerxCalendarResponse.Success = _ctx.BooleanValue("ManageSchedulerxCalendar.Success");

			ManageSchedulerxCalendarResponse.ManageSchedulerxCalendar_AccessDeniedDetail accessDeniedDetail = new ManageSchedulerxCalendarResponse.ManageSchedulerxCalendar_AccessDeniedDetail();
			accessDeniedDetail.PolicyType = _ctx.StringValue("ManageSchedulerxCalendar.AccessDeniedDetail.PolicyType");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("ManageSchedulerxCalendar.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("ManageSchedulerxCalendar.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("ManageSchedulerxCalendar.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("ManageSchedulerxCalendar.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("ManageSchedulerxCalendar.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.AuthAction = _ctx.StringValue("ManageSchedulerxCalendar.AccessDeniedDetail.AuthAction");
			manageSchedulerxCalendarResponse.AccessDeniedDetail = accessDeniedDetail;
        
			return manageSchedulerxCalendarResponse;
        }
    }
}
