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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSecurityStatInfoResponseUnmarshaller
    {
        public static DescribeSecurityStatInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSecurityStatInfoResponse describeSecurityStatInfoResponse = new DescribeSecurityStatInfoResponse();

			describeSecurityStatInfoResponse.HttpResponse = context.HttpResponse;
			describeSecurityStatInfoResponse.RequestId = context.StringValue("DescribeSecurityStatInfo.RequestId");
			describeSecurityStatInfoResponse.Success = context.BooleanValue("DescribeSecurityStatInfo.Success");

			DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_SecurityEvent securityEvent = new DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_SecurityEvent();
			securityEvent.SeriousCount = context.IntegerValue("DescribeSecurityStatInfo.SecurityEvent.SeriousCount");
			securityEvent.SuspiciousCount = context.IntegerValue("DescribeSecurityStatInfo.SecurityEvent.SuspiciousCount");
			securityEvent.RemindCount = context.IntegerValue("DescribeSecurityStatInfo.SecurityEvent.RemindCount");
			securityEvent.TotalCount = context.IntegerValue("DescribeSecurityStatInfo.SecurityEvent.TotalCount");

			List<string> securityEvent_dateArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.SecurityEvent.DateArray.Length"); i++) {
				securityEvent_dateArray.Add(context.StringValue("DescribeSecurityStatInfo.SecurityEvent.DateArray["+ i +"]"));
			}
			securityEvent.DateArray = securityEvent_dateArray;

			List<string> securityEvent_valueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.SecurityEvent.ValueArray.Length"); i++) {
				securityEvent_valueArray.Add(context.StringValue("DescribeSecurityStatInfo.SecurityEvent.ValueArray["+ i +"]"));
			}
			securityEvent.ValueArray = securityEvent_valueArray;

			List<string> securityEvent_levelsOn = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.SecurityEvent.LevelsOn.Length"); i++) {
				securityEvent_levelsOn.Add(context.StringValue("DescribeSecurityStatInfo.SecurityEvent.LevelsOn["+ i +"]"));
			}
			securityEvent.LevelsOn = securityEvent_levelsOn;

			List<string> securityEvent_seriousList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.SecurityEvent.SeriousList.Length"); i++) {
				securityEvent_seriousList.Add(context.StringValue("DescribeSecurityStatInfo.SecurityEvent.SeriousList["+ i +"]"));
			}
			securityEvent.SeriousList = securityEvent_seriousList;

			List<string> securityEvent_suspiciousList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.SecurityEvent.SuspiciousList.Length"); i++) {
				securityEvent_suspiciousList.Add(context.StringValue("DescribeSecurityStatInfo.SecurityEvent.SuspiciousList["+ i +"]"));
			}
			securityEvent.SuspiciousList = securityEvent_suspiciousList;

			List<string> securityEvent_remindList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.SecurityEvent.RemindList.Length"); i++) {
				securityEvent_remindList.Add(context.StringValue("DescribeSecurityStatInfo.SecurityEvent.RemindList["+ i +"]"));
			}
			securityEvent.RemindList = securityEvent_remindList;
			describeSecurityStatInfoResponse.SecurityEvent = securityEvent;

			DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_AttackEvent attackEvent = new DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_AttackEvent();
			attackEvent.TotalCount = context.IntegerValue("DescribeSecurityStatInfo.AttackEvent.TotalCount");

			List<string> attackEvent_dateArray1 = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.AttackEvent.DateArray.Length"); i++) {
				attackEvent_dateArray1.Add(context.StringValue("DescribeSecurityStatInfo.AttackEvent.DateArray["+ i +"]"));
			}
			attackEvent.DateArray1 = attackEvent_dateArray1;

			List<string> attackEvent_valueArray2 = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.AttackEvent.ValueArray.Length"); i++) {
				attackEvent_valueArray2.Add(context.StringValue("DescribeSecurityStatInfo.AttackEvent.ValueArray["+ i +"]"));
			}
			attackEvent.ValueArray2 = attackEvent_valueArray2;
			describeSecurityStatInfoResponse.AttackEvent = attackEvent;

			DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_HealthCheck healthCheck = new DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_HealthCheck();
			healthCheck.MediumCount = context.IntegerValue("DescribeSecurityStatInfo.HealthCheck.MediumCount");
			healthCheck.HighCount = context.IntegerValue("DescribeSecurityStatInfo.HealthCheck.HighCount");
			healthCheck.LowCount = context.IntegerValue("DescribeSecurityStatInfo.HealthCheck.LowCount");
			healthCheck.TotalCount = context.IntegerValue("DescribeSecurityStatInfo.HealthCheck.TotalCount");

			List<string> healthCheck_dateArray3 = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.HealthCheck.DateArray.Length"); i++) {
				healthCheck_dateArray3.Add(context.StringValue("DescribeSecurityStatInfo.HealthCheck.DateArray["+ i +"]"));
			}
			healthCheck.DateArray3 = healthCheck_dateArray3;

			List<string> healthCheck_valueArray4 = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.HealthCheck.ValueArray.Length"); i++) {
				healthCheck_valueArray4.Add(context.StringValue("DescribeSecurityStatInfo.HealthCheck.ValueArray["+ i +"]"));
			}
			healthCheck.ValueArray4 = healthCheck_valueArray4;

			List<string> healthCheck_levelsOn5 = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.HealthCheck.LevelsOn.Length"); i++) {
				healthCheck_levelsOn5.Add(context.StringValue("DescribeSecurityStatInfo.HealthCheck.LevelsOn["+ i +"]"));
			}
			healthCheck.LevelsOn5 = healthCheck_levelsOn5;

			List<string> healthCheck_highList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.HealthCheck.HighList.Length"); i++) {
				healthCheck_highList.Add(context.StringValue("DescribeSecurityStatInfo.HealthCheck.HighList["+ i +"]"));
			}
			healthCheck.HighList = healthCheck_highList;

			List<string> healthCheck_mediumList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.HealthCheck.MediumList.Length"); i++) {
				healthCheck_mediumList.Add(context.StringValue("DescribeSecurityStatInfo.HealthCheck.MediumList["+ i +"]"));
			}
			healthCheck.MediumList = healthCheck_mediumList;

			List<string> healthCheck_lowList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.HealthCheck.LowList.Length"); i++) {
				healthCheck_lowList.Add(context.StringValue("DescribeSecurityStatInfo.HealthCheck.LowList["+ i +"]"));
			}
			healthCheck.LowList = healthCheck_lowList;
			describeSecurityStatInfoResponse.HealthCheck = healthCheck;

			DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_Vulnerability vulnerability = new DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_Vulnerability();
			vulnerability.NntfCount = context.IntegerValue("DescribeSecurityStatInfo.Vulnerability.NntfCount");
			vulnerability.LaterCount = context.IntegerValue("DescribeSecurityStatInfo.Vulnerability.LaterCount");
			vulnerability.AsapCount = context.IntegerValue("DescribeSecurityStatInfo.Vulnerability.AsapCount");
			vulnerability.TotalCount = context.IntegerValue("DescribeSecurityStatInfo.Vulnerability.TotalCount");

			List<string> vulnerability_dateArray6 = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.Vulnerability.DateArray.Length"); i++) {
				vulnerability_dateArray6.Add(context.StringValue("DescribeSecurityStatInfo.Vulnerability.DateArray["+ i +"]"));
			}
			vulnerability.DateArray6 = vulnerability_dateArray6;

			List<string> vulnerability_valueArray7 = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.Vulnerability.ValueArray.Length"); i++) {
				vulnerability_valueArray7.Add(context.StringValue("DescribeSecurityStatInfo.Vulnerability.ValueArray["+ i +"]"));
			}
			vulnerability.ValueArray7 = vulnerability_valueArray7;

			List<string> vulnerability_levelsOn8 = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.Vulnerability.LevelsOn.Length"); i++) {
				vulnerability_levelsOn8.Add(context.StringValue("DescribeSecurityStatInfo.Vulnerability.LevelsOn["+ i +"]"));
			}
			vulnerability.LevelsOn8 = vulnerability_levelsOn8;

			List<string> vulnerability_nntfList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.Vulnerability.NntfList.Length"); i++) {
				vulnerability_nntfList.Add(context.StringValue("DescribeSecurityStatInfo.Vulnerability.NntfList["+ i +"]"));
			}
			vulnerability.NntfList = vulnerability_nntfList;

			List<string> vulnerability_asapList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.Vulnerability.AsapList.Length"); i++) {
				vulnerability_asapList.Add(context.StringValue("DescribeSecurityStatInfo.Vulnerability.AsapList["+ i +"]"));
			}
			vulnerability.AsapList = vulnerability_asapList;

			List<string> vulnerability_laterList = new List<string>();
			for (int i = 0; i < context.Length("DescribeSecurityStatInfo.Vulnerability.LaterList.Length"); i++) {
				vulnerability_laterList.Add(context.StringValue("DescribeSecurityStatInfo.Vulnerability.LaterList["+ i +"]"));
			}
			vulnerability.LaterList = vulnerability_laterList;
			describeSecurityStatInfoResponse.Vulnerability = vulnerability;
        
			return describeSecurityStatInfoResponse;
        }
    }
}
