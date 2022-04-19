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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSecurityStatInfoResponseUnmarshaller
    {
        public static DescribeSecurityStatInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecurityStatInfoResponse describeSecurityStatInfoResponse = new DescribeSecurityStatInfoResponse();

			describeSecurityStatInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeSecurityStatInfoResponse.Success = _ctx.BooleanValue("DescribeSecurityStatInfo.Success");
			describeSecurityStatInfoResponse.RequestId = _ctx.StringValue("DescribeSecurityStatInfo.RequestId");

			DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_SecurityEvent securityEvent = new DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_SecurityEvent();
			securityEvent.SuspiciousCount = _ctx.IntegerValue("DescribeSecurityStatInfo.SecurityEvent.SuspiciousCount");
			securityEvent.SeriousCount = _ctx.IntegerValue("DescribeSecurityStatInfo.SecurityEvent.SeriousCount");
			securityEvent.RemindCount = _ctx.IntegerValue("DescribeSecurityStatInfo.SecurityEvent.RemindCount");
			securityEvent.TotalCount = _ctx.IntegerValue("DescribeSecurityStatInfo.SecurityEvent.TotalCount");

			List<string> securityEvent_valueArray = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.SecurityEvent.ValueArray.Length"); i++) {
				securityEvent_valueArray.Add(_ctx.StringValue("DescribeSecurityStatInfo.SecurityEvent.ValueArray["+ i +"]"));
			}
			securityEvent.ValueArray = securityEvent_valueArray;

			List<string> securityEvent_timeArray = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.SecurityEvent.TimeArray.Length"); i++) {
				securityEvent_timeArray.Add(_ctx.StringValue("DescribeSecurityStatInfo.SecurityEvent.TimeArray["+ i +"]"));
			}
			securityEvent.TimeArray = securityEvent_timeArray;

			List<string> securityEvent_remindList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.SecurityEvent.RemindList.Length"); i++) {
				securityEvent_remindList.Add(_ctx.StringValue("DescribeSecurityStatInfo.SecurityEvent.RemindList["+ i +"]"));
			}
			securityEvent.RemindList = securityEvent_remindList;

			List<string> securityEvent_levelsOn = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.SecurityEvent.LevelsOn.Length"); i++) {
				securityEvent_levelsOn.Add(_ctx.StringValue("DescribeSecurityStatInfo.SecurityEvent.LevelsOn["+ i +"]"));
			}
			securityEvent.LevelsOn = securityEvent_levelsOn;

			List<string> securityEvent_dateArray = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.SecurityEvent.DateArray.Length"); i++) {
				securityEvent_dateArray.Add(_ctx.StringValue("DescribeSecurityStatInfo.SecurityEvent.DateArray["+ i +"]"));
			}
			securityEvent.DateArray = securityEvent_dateArray;

			List<string> securityEvent_suspiciousList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.SecurityEvent.SuspiciousList.Length"); i++) {
				securityEvent_suspiciousList.Add(_ctx.StringValue("DescribeSecurityStatInfo.SecurityEvent.SuspiciousList["+ i +"]"));
			}
			securityEvent.SuspiciousList = securityEvent_suspiciousList;

			List<string> securityEvent_seriousList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.SecurityEvent.SeriousList.Length"); i++) {
				securityEvent_seriousList.Add(_ctx.StringValue("DescribeSecurityStatInfo.SecurityEvent.SeriousList["+ i +"]"));
			}
			securityEvent.SeriousList = securityEvent_seriousList;
			describeSecurityStatInfoResponse.SecurityEvent = securityEvent;

			DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_AttackEvent attackEvent = new DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_AttackEvent();
			attackEvent.TotalCount = _ctx.IntegerValue("DescribeSecurityStatInfo.AttackEvent.TotalCount");

			List<string> attackEvent_dateArray1 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.AttackEvent.DateArray.Length"); i++) {
				attackEvent_dateArray1.Add(_ctx.StringValue("DescribeSecurityStatInfo.AttackEvent.DateArray["+ i +"]"));
			}
			attackEvent.DateArray1 = attackEvent_dateArray1;

			List<string> attackEvent_valueArray2 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.AttackEvent.ValueArray.Length"); i++) {
				attackEvent_valueArray2.Add(_ctx.StringValue("DescribeSecurityStatInfo.AttackEvent.ValueArray["+ i +"]"));
			}
			attackEvent.ValueArray2 = attackEvent_valueArray2;
			describeSecurityStatInfoResponse.AttackEvent = attackEvent;

			DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_HealthCheck healthCheck = new DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_HealthCheck();
			healthCheck.HighCount = _ctx.IntegerValue("DescribeSecurityStatInfo.HealthCheck.HighCount");
			healthCheck.LowCount = _ctx.IntegerValue("DescribeSecurityStatInfo.HealthCheck.LowCount");
			healthCheck.TotalCount = _ctx.IntegerValue("DescribeSecurityStatInfo.HealthCheck.TotalCount");
			healthCheck.MediumCount = _ctx.IntegerValue("DescribeSecurityStatInfo.HealthCheck.MediumCount");

			List<string> healthCheck_valueArray3 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.HealthCheck.ValueArray.Length"); i++) {
				healthCheck_valueArray3.Add(_ctx.StringValue("DescribeSecurityStatInfo.HealthCheck.ValueArray["+ i +"]"));
			}
			healthCheck.ValueArray3 = healthCheck_valueArray3;

			List<string> healthCheck_timeArray4 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.HealthCheck.TimeArray.Length"); i++) {
				healthCheck_timeArray4.Add(_ctx.StringValue("DescribeSecurityStatInfo.HealthCheck.TimeArray["+ i +"]"));
			}
			healthCheck.TimeArray4 = healthCheck_timeArray4;

			List<string> healthCheck_levelsOn5 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.HealthCheck.LevelsOn.Length"); i++) {
				healthCheck_levelsOn5.Add(_ctx.StringValue("DescribeSecurityStatInfo.HealthCheck.LevelsOn["+ i +"]"));
			}
			healthCheck.LevelsOn5 = healthCheck_levelsOn5;

			List<string> healthCheck_lowList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.HealthCheck.LowList.Length"); i++) {
				healthCheck_lowList.Add(_ctx.StringValue("DescribeSecurityStatInfo.HealthCheck.LowList["+ i +"]"));
			}
			healthCheck.LowList = healthCheck_lowList;

			List<string> healthCheck_mediumList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.HealthCheck.MediumList.Length"); i++) {
				healthCheck_mediumList.Add(_ctx.StringValue("DescribeSecurityStatInfo.HealthCheck.MediumList["+ i +"]"));
			}
			healthCheck.MediumList = healthCheck_mediumList;

			List<string> healthCheck_dateArray6 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.HealthCheck.DateArray.Length"); i++) {
				healthCheck_dateArray6.Add(_ctx.StringValue("DescribeSecurityStatInfo.HealthCheck.DateArray["+ i +"]"));
			}
			healthCheck.DateArray6 = healthCheck_dateArray6;

			List<string> healthCheck_highList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.HealthCheck.HighList.Length"); i++) {
				healthCheck_highList.Add(_ctx.StringValue("DescribeSecurityStatInfo.HealthCheck.HighList["+ i +"]"));
			}
			healthCheck.HighList = healthCheck_highList;
			describeSecurityStatInfoResponse.HealthCheck = healthCheck;

			DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_Vulnerability vulnerability = new DescribeSecurityStatInfoResponse.DescribeSecurityStatInfo_Vulnerability();
			vulnerability.NntfCount = _ctx.IntegerValue("DescribeSecurityStatInfo.Vulnerability.NntfCount");
			vulnerability.LaterCount = _ctx.IntegerValue("DescribeSecurityStatInfo.Vulnerability.LaterCount");
			vulnerability.TotalCount = _ctx.IntegerValue("DescribeSecurityStatInfo.Vulnerability.TotalCount");
			vulnerability.AsapCount = _ctx.IntegerValue("DescribeSecurityStatInfo.Vulnerability.AsapCount");

			List<string> vulnerability_nntfList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.Vulnerability.NntfList.Length"); i++) {
				vulnerability_nntfList.Add(_ctx.StringValue("DescribeSecurityStatInfo.Vulnerability.NntfList["+ i +"]"));
			}
			vulnerability.NntfList = vulnerability_nntfList;

			List<string> vulnerability_asapList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.Vulnerability.AsapList.Length"); i++) {
				vulnerability_asapList.Add(_ctx.StringValue("DescribeSecurityStatInfo.Vulnerability.AsapList["+ i +"]"));
			}
			vulnerability.AsapList = vulnerability_asapList;

			List<string> vulnerability_valueArray7 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.Vulnerability.ValueArray.Length"); i++) {
				vulnerability_valueArray7.Add(_ctx.StringValue("DescribeSecurityStatInfo.Vulnerability.ValueArray["+ i +"]"));
			}
			vulnerability.ValueArray7 = vulnerability_valueArray7;

			List<string> vulnerability_timeArray8 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.Vulnerability.TimeArray.Length"); i++) {
				vulnerability_timeArray8.Add(_ctx.StringValue("DescribeSecurityStatInfo.Vulnerability.TimeArray["+ i +"]"));
			}
			vulnerability.TimeArray8 = vulnerability_timeArray8;

			List<string> vulnerability_levelsOn9 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.Vulnerability.LevelsOn.Length"); i++) {
				vulnerability_levelsOn9.Add(_ctx.StringValue("DescribeSecurityStatInfo.Vulnerability.LevelsOn["+ i +"]"));
			}
			vulnerability.LevelsOn9 = vulnerability_levelsOn9;

			List<string> vulnerability_laterList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.Vulnerability.LaterList.Length"); i++) {
				vulnerability_laterList.Add(_ctx.StringValue("DescribeSecurityStatInfo.Vulnerability.LaterList["+ i +"]"));
			}
			vulnerability.LaterList = vulnerability_laterList;

			List<string> vulnerability_dateArray10 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityStatInfo.Vulnerability.DateArray.Length"); i++) {
				vulnerability_dateArray10.Add(_ctx.StringValue("DescribeSecurityStatInfo.Vulnerability.DateArray["+ i +"]"));
			}
			vulnerability.DateArray10 = vulnerability_dateArray10;
			describeSecurityStatInfoResponse.Vulnerability = vulnerability;
        
			return describeSecurityStatInfoResponse;
        }
    }
}
