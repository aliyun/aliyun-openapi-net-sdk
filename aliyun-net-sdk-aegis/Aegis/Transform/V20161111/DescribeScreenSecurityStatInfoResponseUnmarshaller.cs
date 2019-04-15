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
    public class DescribeScreenSecurityStatInfoResponseUnmarshaller
    {
        public static DescribeScreenSecurityStatInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScreenSecurityStatInfoResponse describeScreenSecurityStatInfoResponse = new DescribeScreenSecurityStatInfoResponse();

			describeScreenSecurityStatInfoResponse.HttpResponse = context.HttpResponse;
			describeScreenSecurityStatInfoResponse.RequestId = context.StringValue("DescribeScreenSecurityStatInfo.RequestId");
			describeScreenSecurityStatInfoResponse.Success = context.BooleanValue("DescribeScreenSecurityStatInfo.Success");

			DescribeScreenSecurityStatInfoResponse.DescribeScreenSecurityStatInfo_SecurityEvent securityEvent = new DescribeScreenSecurityStatInfoResponse.DescribeScreenSecurityStatInfo_SecurityEvent();
			securityEvent.SeriousCount = context.IntegerValue("DescribeScreenSecurityStatInfo.SecurityEvent.SeriousCount");
			securityEvent.SuspiciousCount = context.IntegerValue("DescribeScreenSecurityStatInfo.SecurityEvent.SuspiciousCount");
			securityEvent.RemindCount = context.IntegerValue("DescribeScreenSecurityStatInfo.SecurityEvent.RemindCount");
			securityEvent.TotalCount = context.IntegerValue("DescribeScreenSecurityStatInfo.SecurityEvent.TotalCount");

			List<string> securityEvent_dateArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.SecurityEvent.DateArray.Length"); i++) {
				securityEvent_dateArray.Add(context.StringValue("DescribeScreenSecurityStatInfo.SecurityEvent.DateArray["+ i +"]"));
			}
			securityEvent.DateArray = securityEvent_dateArray;

			List<string> securityEvent_valueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.SecurityEvent.ValueArray.Length"); i++) {
				securityEvent_valueArray.Add(context.StringValue("DescribeScreenSecurityStatInfo.SecurityEvent.ValueArray["+ i +"]"));
			}
			securityEvent.ValueArray = securityEvent_valueArray;

			List<string> securityEvent_levelsOn = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.SecurityEvent.LevelsOn.Length"); i++) {
				securityEvent_levelsOn.Add(context.StringValue("DescribeScreenSecurityStatInfo.SecurityEvent.LevelsOn["+ i +"]"));
			}
			securityEvent.LevelsOn = securityEvent_levelsOn;

			List<string> securityEvent_seriousList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.SecurityEvent.SeriousList.Length"); i++) {
				securityEvent_seriousList.Add(context.StringValue("DescribeScreenSecurityStatInfo.SecurityEvent.SeriousList["+ i +"]"));
			}
			securityEvent.SeriousList = securityEvent_seriousList;

			List<string> securityEvent_suspiciousList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.SecurityEvent.SuspiciousList.Length"); i++) {
				securityEvent_suspiciousList.Add(context.StringValue("DescribeScreenSecurityStatInfo.SecurityEvent.SuspiciousList["+ i +"]"));
			}
			securityEvent.SuspiciousList = securityEvent_suspiciousList;

			List<string> securityEvent_remindList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.SecurityEvent.RemindList.Length"); i++) {
				securityEvent_remindList.Add(context.StringValue("DescribeScreenSecurityStatInfo.SecurityEvent.RemindList["+ i +"]"));
			}
			securityEvent.RemindList = securityEvent_remindList;
			describeScreenSecurityStatInfoResponse.SecurityEvent = securityEvent;

			DescribeScreenSecurityStatInfoResponse.DescribeScreenSecurityStatInfo_AttackEvent attackEvent = new DescribeScreenSecurityStatInfoResponse.DescribeScreenSecurityStatInfo_AttackEvent();
			attackEvent.TotalCount = context.IntegerValue("DescribeScreenSecurityStatInfo.AttackEvent.TotalCount");

			List<string> attackEvent_dateArray1 = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.AttackEvent.DateArray.Length"); i++) {
				attackEvent_dateArray1.Add(context.StringValue("DescribeScreenSecurityStatInfo.AttackEvent.DateArray["+ i +"]"));
			}
			attackEvent.DateArray1 = attackEvent_dateArray1;

			List<string> attackEvent_valueArray2 = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.AttackEvent.ValueArray.Length"); i++) {
				attackEvent_valueArray2.Add(context.StringValue("DescribeScreenSecurityStatInfo.AttackEvent.ValueArray["+ i +"]"));
			}
			attackEvent.ValueArray2 = attackEvent_valueArray2;
			describeScreenSecurityStatInfoResponse.AttackEvent = attackEvent;

			DescribeScreenSecurityStatInfoResponse.DescribeScreenSecurityStatInfo_HealthCheck healthCheck = new DescribeScreenSecurityStatInfoResponse.DescribeScreenSecurityStatInfo_HealthCheck();
			healthCheck.MediumCount = context.IntegerValue("DescribeScreenSecurityStatInfo.HealthCheck.MediumCount");
			healthCheck.HighCount = context.IntegerValue("DescribeScreenSecurityStatInfo.HealthCheck.HighCount");
			healthCheck.LowCount = context.IntegerValue("DescribeScreenSecurityStatInfo.HealthCheck.LowCount");
			healthCheck.TotalCount = context.IntegerValue("DescribeScreenSecurityStatInfo.HealthCheck.TotalCount");

			List<string> healthCheck_dateArray3 = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.HealthCheck.DateArray.Length"); i++) {
				healthCheck_dateArray3.Add(context.StringValue("DescribeScreenSecurityStatInfo.HealthCheck.DateArray["+ i +"]"));
			}
			healthCheck.DateArray3 = healthCheck_dateArray3;

			List<string> healthCheck_valueArray4 = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.HealthCheck.ValueArray.Length"); i++) {
				healthCheck_valueArray4.Add(context.StringValue("DescribeScreenSecurityStatInfo.HealthCheck.ValueArray["+ i +"]"));
			}
			healthCheck.ValueArray4 = healthCheck_valueArray4;

			List<string> healthCheck_levelsOn5 = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.HealthCheck.LevelsOn.Length"); i++) {
				healthCheck_levelsOn5.Add(context.StringValue("DescribeScreenSecurityStatInfo.HealthCheck.LevelsOn["+ i +"]"));
			}
			healthCheck.LevelsOn5 = healthCheck_levelsOn5;

			List<string> healthCheck_highList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.HealthCheck.HighList.Length"); i++) {
				healthCheck_highList.Add(context.StringValue("DescribeScreenSecurityStatInfo.HealthCheck.HighList["+ i +"]"));
			}
			healthCheck.HighList = healthCheck_highList;

			List<string> healthCheck_mediumList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.HealthCheck.MediumList.Length"); i++) {
				healthCheck_mediumList.Add(context.StringValue("DescribeScreenSecurityStatInfo.HealthCheck.MediumList["+ i +"]"));
			}
			healthCheck.MediumList = healthCheck_mediumList;

			List<string> healthCheck_lowList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.HealthCheck.LowList.Length"); i++) {
				healthCheck_lowList.Add(context.StringValue("DescribeScreenSecurityStatInfo.HealthCheck.LowList["+ i +"]"));
			}
			healthCheck.LowList = healthCheck_lowList;
			describeScreenSecurityStatInfoResponse.HealthCheck = healthCheck;

			DescribeScreenSecurityStatInfoResponse.DescribeScreenSecurityStatInfo_Vulnerability vulnerability = new DescribeScreenSecurityStatInfoResponse.DescribeScreenSecurityStatInfo_Vulnerability();
			vulnerability.NntfCount = context.IntegerValue("DescribeScreenSecurityStatInfo.Vulnerability.NntfCount");
			vulnerability.LaterCount = context.IntegerValue("DescribeScreenSecurityStatInfo.Vulnerability.LaterCount");
			vulnerability.AsapCount = context.IntegerValue("DescribeScreenSecurityStatInfo.Vulnerability.AsapCount");
			vulnerability.TotalCount = context.IntegerValue("DescribeScreenSecurityStatInfo.Vulnerability.TotalCount");

			List<string> vulnerability_dateArray6 = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.Vulnerability.DateArray.Length"); i++) {
				vulnerability_dateArray6.Add(context.StringValue("DescribeScreenSecurityStatInfo.Vulnerability.DateArray["+ i +"]"));
			}
			vulnerability.DateArray6 = vulnerability_dateArray6;

			List<string> vulnerability_valueArray7 = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.Vulnerability.ValueArray.Length"); i++) {
				vulnerability_valueArray7.Add(context.StringValue("DescribeScreenSecurityStatInfo.Vulnerability.ValueArray["+ i +"]"));
			}
			vulnerability.ValueArray7 = vulnerability_valueArray7;

			List<string> vulnerability_levelsOn8 = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.Vulnerability.LevelsOn.Length"); i++) {
				vulnerability_levelsOn8.Add(context.StringValue("DescribeScreenSecurityStatInfo.Vulnerability.LevelsOn["+ i +"]"));
			}
			vulnerability.LevelsOn8 = vulnerability_levelsOn8;

			List<string> vulnerability_nntfList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.Vulnerability.NntfList.Length"); i++) {
				vulnerability_nntfList.Add(context.StringValue("DescribeScreenSecurityStatInfo.Vulnerability.NntfList["+ i +"]"));
			}
			vulnerability.NntfList = vulnerability_nntfList;

			List<string> vulnerability_asapList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.Vulnerability.AsapList.Length"); i++) {
				vulnerability_asapList.Add(context.StringValue("DescribeScreenSecurityStatInfo.Vulnerability.AsapList["+ i +"]"));
			}
			vulnerability.AsapList = vulnerability_asapList;

			List<string> vulnerability_laterList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenSecurityStatInfo.Vulnerability.LaterList.Length"); i++) {
				vulnerability_laterList.Add(context.StringValue("DescribeScreenSecurityStatInfo.Vulnerability.LaterList["+ i +"]"));
			}
			vulnerability.LaterList = vulnerability_laterList;
			describeScreenSecurityStatInfoResponse.Vulnerability = vulnerability;
        
			return describeScreenSecurityStatInfoResponse;
        }
    }
}
