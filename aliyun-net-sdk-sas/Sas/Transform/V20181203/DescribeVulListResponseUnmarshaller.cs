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
    public class DescribeVulListResponseUnmarshaller
    {
        public static DescribeVulListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVulListResponse describeVulListResponse = new DescribeVulListResponse();

			describeVulListResponse.HttpResponse = _ctx.HttpResponse;
			describeVulListResponse.CurrentPage = _ctx.IntegerValue("DescribeVulList.CurrentPage");
			describeVulListResponse.RequestId = _ctx.StringValue("DescribeVulList.RequestId");
			describeVulListResponse.PageSize = _ctx.IntegerValue("DescribeVulList.PageSize");
			describeVulListResponse.TotalCount = _ctx.IntegerValue("DescribeVulList.TotalCount");

			List<DescribeVulListResponse.DescribeVulList_VulRecord> describeVulListResponse_vulRecords = new List<DescribeVulListResponse.DescribeVulList_VulRecord>();
			for (int i = 0; i < _ctx.Length("DescribeVulList.VulRecords.Length"); i++) {
				DescribeVulListResponse.DescribeVulList_VulRecord vulRecord = new DescribeVulListResponse.DescribeVulList_VulRecord();
				vulRecord.Status = _ctx.IntegerValue("DescribeVulList.VulRecords["+ i +"].Status");
				vulRecord.Type = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].Type");
				vulRecord.ModifyTs = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].ModifyTs");
				vulRecord.InternetIp = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].InternetIp");
				vulRecord.RecordId = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].RecordId");
				vulRecord.ContainerImageId = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ContainerImageId");
				vulRecord.PrimaryId = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].PrimaryId");
				vulRecord.Tag = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].Tag");
				vulRecord.K8sClusterId = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].K8sClusterId");
				vulRecord.ContainerImageName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ContainerImageName");
				vulRecord.K8sNodeId = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].K8sNodeId");
				vulRecord.InstanceName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].InstanceName");
				vulRecord.ContainerInnerPath = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ContainerInnerPath");
				vulRecord.Online = _ctx.BooleanValue("DescribeVulList.VulRecords["+ i +"].Online");
				vulRecord.OsVersion = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].OsVersion");
				vulRecord.Name = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].Name");
				vulRecord.CanFix = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].CanFix");
				vulRecord.Progress = _ctx.IntegerValue("DescribeVulList.VulRecords["+ i +"].Progress");
				vulRecord.Ip = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].Ip");
				vulRecord.NeedReboot = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].NeedReboot");
				vulRecord.ResultCode = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ResultCode");
				vulRecord.InstanceId = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].InstanceId");
				vulRecord.Related = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].Related");
				vulRecord.IntranetIp = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].IntranetIp");
				vulRecord.LastTs = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].LastTs");
				vulRecord.FirstTs = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].FirstTs");
				vulRecord.RegionId = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].RegionId");
				vulRecord.Necessity = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].Necessity");
				vulRecord.RepairTs = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].RepairTs");
				vulRecord.Uuid = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].Uuid");
				vulRecord.K8sPodName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].K8sPodName");
				vulRecord.ContainerId = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ContainerId");
				vulRecord.GroupId = _ctx.IntegerValue("DescribeVulList.VulRecords["+ i +"].GroupId");
				vulRecord.ResultMessage = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ResultMessage");
				vulRecord.K8sNamespace = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].K8sNamespace");
				vulRecord.AliasName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].AliasName");
				vulRecord.K8sNodeName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].K8sNodeName");
				vulRecord.ContainerName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ContainerName");
				vulRecord.Level = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].Level");
				vulRecord.Bind = _ctx.BooleanValue("DescribeVulList.VulRecords["+ i +"].Bind");
				vulRecord.OsName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].OsName");
				vulRecord.AuthVersion = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].AuthVersion");

				DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson extendContentJson = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson();
				extendContentJson.Status = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Status");
				extendContentJson.Effect = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Effect");
				extendContentJson.EmgProof = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.EmgProof");
				extendContentJson.Owasp = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Owasp");
				extendContentJson.Cwe = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Cwe");
				extendContentJson.Ip = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Ip");
				extendContentJson.PrimaryId = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.PrimaryId");
				extendContentJson.Os = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Os");
				extendContentJson.Tag = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Tag");
				extendContentJson.Reference = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Reference");
				extendContentJson.Wasc = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Wasc");
				extendContentJson.LastTs = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.LastTs");
				extendContentJson.VulType = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.VulType");
				extendContentJson.Description = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Description");
				extendContentJson.OsRelease = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.OsRelease");
				extendContentJson.Title = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Title");
				extendContentJson.AliasName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.AliasName");
				extendContentJson.Solution = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Solution");
				extendContentJson.Target = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Target");
				extendContentJson.AbsolutePath = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.AbsolutePath");
				extendContentJson.Proof = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Proof");
				extendContentJson.Reason = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Reason");

				List<string> extendContentJson_cveList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.CveList.Length"); j++) {
					extendContentJson_cveList.Add(_ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.CveList["+ j +"]"));
				}
				extendContentJson.CveList = extendContentJson_cveList;

				DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_Necessity necessity = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_Necessity();
				necessity.Status = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Status");
				necessity.Gmt_create = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Gmt_create");
				necessity.Time_factor = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Time_factor");
				necessity.Enviroment_factor = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Enviroment_factor");
				necessity.Is_calc = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Is_calc");
				necessity.Total_score = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Total_score");
				necessity.Cvss_factor = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Cvss_factor");
				necessity.Assets_factor = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Assets_factor");
				extendContentJson.Necessity = necessity;

				List<DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_RpmEntity> extendContentJson_rpmEntityList = new List<DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_RpmEntity>();
				for (int j = 0; j < _ctx.Length("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList.Length"); j++) {
					DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_RpmEntity rpmEntity = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_RpmEntity();
					rpmEntity.FullVersion = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].FullVersion");
					rpmEntity.Version = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Version");
					rpmEntity.MatchDetail = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].MatchDetail");
					rpmEntity.ImageName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].ImageName");
					rpmEntity.Path = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Path");
					rpmEntity.ContainerName = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].ContainerName");
					rpmEntity.Name = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Name");
					rpmEntity.UpdateCmd = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].UpdateCmd");
					rpmEntity.Pid = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Pid");

					List<string> rpmEntity_matchList = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].MatchList.Length"); k++) {
						rpmEntity_matchList.Add(_ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].MatchList["+ k +"]"));
					}
					rpmEntity.MatchList = rpmEntity_matchList;

					extendContentJson_rpmEntityList.Add(rpmEntity);
				}
				extendContentJson.RpmEntityList = extendContentJson_rpmEntityList;
				vulRecord.ExtendContentJson = extendContentJson;

				DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo processInfo = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo();
				processInfo.TotalCount = _ctx.IntegerValue("DescribeVulList.VulRecords["+ i +"].ProcessInfo.TotalCount");
				processInfo.GmtLastTs = _ctx.LongValue("DescribeVulList.VulRecords["+ i +"].ProcessInfo.GmtLastTs");

				List<DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo.DescribeVulList_Process> processInfo_processList = new List<DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo.DescribeVulList_Process>();
				for (int j = 0; j < _ctx.Length("DescribeVulList.VulRecords["+ i +"].ProcessInfo.ProcessList.Length"); j++) {
					DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo.DescribeVulList_Process process = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo.DescribeVulList_Process();
					process.Rpm = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ProcessInfo.ProcessList["+ j +"].Rpm");
					process.Pname = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ProcessInfo.ProcessList["+ j +"].Pname");
					process.Pid = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ProcessInfo.ProcessList["+ j +"].Pid");

					List<DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo.DescribeVulList_Process.DescribeVulList_SubProcess> process_subProcessList = new List<DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo.DescribeVulList_Process.DescribeVulList_SubProcess>();
					for (int k = 0; k < _ctx.Length("DescribeVulList.VulRecords["+ i +"].ProcessInfo.ProcessList["+ j +"].SubProcessList.Length"); k++) {
						DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo.DescribeVulList_Process.DescribeVulList_SubProcess subProcess = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ProcessInfo.DescribeVulList_Process.DescribeVulList_SubProcess();
						subProcess.Rpm = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ProcessInfo.ProcessList["+ j +"].SubProcessList["+ k +"].Rpm");
						subProcess.Pname = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ProcessInfo.ProcessList["+ j +"].SubProcessList["+ k +"].Pname");
						subProcess.Pid = _ctx.StringValue("DescribeVulList.VulRecords["+ i +"].ProcessInfo.ProcessList["+ j +"].SubProcessList["+ k +"].Pid");

						process_subProcessList.Add(subProcess);
					}
					process.SubProcessList = process_subProcessList;

					processInfo_processList.Add(process);
				}
				processInfo.ProcessList = processInfo_processList;
				vulRecord.ProcessInfo = processInfo;

				describeVulListResponse_vulRecords.Add(vulRecord);
			}
			describeVulListResponse.VulRecords = describeVulListResponse_vulRecords;
        
			return describeVulListResponse;
        }
    }
}
