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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetRemindResponseUnmarshaller
    {
        public static GetRemindResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRemindResponse getRemindResponse = new GetRemindResponse();

			getRemindResponse.HttpResponse = _ctx.HttpResponse;
			getRemindResponse.Success = _ctx.BooleanValue("GetRemind.Success");
			getRemindResponse.ErrorCode = _ctx.StringValue("GetRemind.ErrorCode");
			getRemindResponse.ErrorMessage = _ctx.StringValue("GetRemind.ErrorMessage");
			getRemindResponse.HttpStatusCode = _ctx.IntegerValue("GetRemind.HttpStatusCode");
			getRemindResponse.RequestId = _ctx.StringValue("GetRemind.RequestId");

			GetRemindResponse.GetRemind_Data data = new GetRemindResponse.GetRemind_Data();
			data.RemindId = _ctx.LongValue("GetRemind.Data.RemindId");
			data.RemindName = _ctx.StringValue("GetRemind.Data.RemindName");
			data.DndStart = _ctx.StringValue("GetRemind.Data.DndStart");
			data.DndEnd = _ctx.StringValue("GetRemind.Data.DndEnd");
			data.RemindUnit = _ctx.StringValue("GetRemind.Data.RemindUnit");
			data.RemindType = _ctx.StringValue("GetRemind.Data.RemindType");
			data.AlertUnit = _ctx.StringValue("GetRemind.Data.AlertUnit");
			data.Useflag = _ctx.BooleanValue("GetRemind.Data.Useflag");
			data.Founder = _ctx.StringValue("GetRemind.Data.Founder");
			data.AlertInterval = _ctx.IntegerValue("GetRemind.Data.AlertInterval");
			data.Detail = _ctx.StringValue("GetRemind.Data.Detail");
			data.MaxAlertTimes = _ctx.IntegerValue("GetRemind.Data.MaxAlertTimes");

			List<string> data_alertMethods = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRemind.Data.AlertMethods.Length"); i++) {
				data_alertMethods.Add(_ctx.StringValue("GetRemind.Data.AlertMethods["+ i +"]"));
			}
			data.AlertMethods = data_alertMethods;

			List<string> data_alertTargets = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRemind.Data.AlertTargets.Length"); i++) {
				data_alertTargets.Add(_ctx.StringValue("GetRemind.Data.AlertTargets["+ i +"]"));
			}
			data.AlertTargets = data_alertTargets;

			List<GetRemindResponse.GetRemind_Data.GetRemind_RobotsItem> data_robots = new List<GetRemindResponse.GetRemind_Data.GetRemind_RobotsItem>();
			for (int i = 0; i < _ctx.Length("GetRemind.Data.Robots.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_RobotsItem robotsItem = new GetRemindResponse.GetRemind_Data.GetRemind_RobotsItem();
				robotsItem.WebUrl = _ctx.StringValue("GetRemind.Data.Robots["+ i +"].WebUrl");
				robotsItem.AtAll = _ctx.BooleanValue("GetRemind.Data.Robots["+ i +"].AtAll");

				data_robots.Add(robotsItem);
			}
			data.Robots = data_robots;

			List<GetRemindResponse.GetRemind_Data.GetRemind_NodesItem> data_nodes = new List<GetRemindResponse.GetRemind_Data.GetRemind_NodesItem>();
			for (int i = 0; i < _ctx.Length("GetRemind.Data.Nodes.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_NodesItem nodesItem = new GetRemindResponse.GetRemind_Data.GetRemind_NodesItem();
				nodesItem.NodeId = _ctx.LongValue("GetRemind.Data.Nodes["+ i +"].NodeId");
				nodesItem.NodeName = _ctx.StringValue("GetRemind.Data.Nodes["+ i +"].NodeName");
				nodesItem.Owner = _ctx.StringValue("GetRemind.Data.Nodes["+ i +"].Owner");
				nodesItem.ProjectId = _ctx.LongValue("GetRemind.Data.Nodes["+ i +"].ProjectId");

				data_nodes.Add(nodesItem);
			}
			data.Nodes = data_nodes;

			List<GetRemindResponse.GetRemind_Data.GetRemind_BaselinesItem> data_baselines = new List<GetRemindResponse.GetRemind_Data.GetRemind_BaselinesItem>();
			for (int i = 0; i < _ctx.Length("GetRemind.Data.Baselines.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_BaselinesItem baselinesItem = new GetRemindResponse.GetRemind_Data.GetRemind_BaselinesItem();
				baselinesItem.BaselineId = _ctx.LongValue("GetRemind.Data.Baselines["+ i +"].BaselineId");
				baselinesItem.BaselineName = _ctx.StringValue("GetRemind.Data.Baselines["+ i +"].BaselineName");

				data_baselines.Add(baselinesItem);
			}
			data.Baselines = data_baselines;

			List<GetRemindResponse.GetRemind_Data.GetRemind_ProjectsItem> data_projects = new List<GetRemindResponse.GetRemind_Data.GetRemind_ProjectsItem>();
			for (int i = 0; i < _ctx.Length("GetRemind.Data.Projects.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_ProjectsItem projectsItem = new GetRemindResponse.GetRemind_Data.GetRemind_ProjectsItem();
				projectsItem.ProjectId = _ctx.LongValue("GetRemind.Data.Projects["+ i +"].ProjectId");

				data_projects.Add(projectsItem);
			}
			data.Projects = data_projects;

			List<GetRemindResponse.GetRemind_Data.GetRemind_BizProcessesItem> data_bizProcesses = new List<GetRemindResponse.GetRemind_Data.GetRemind_BizProcessesItem>();
			for (int i = 0; i < _ctx.Length("GetRemind.Data.BizProcesses.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_BizProcessesItem bizProcessesItem = new GetRemindResponse.GetRemind_Data.GetRemind_BizProcessesItem();
				bizProcessesItem.BizId = _ctx.LongValue("GetRemind.Data.BizProcesses["+ i +"].BizId");
				bizProcessesItem.BizProcessName = _ctx.StringValue("GetRemind.Data.BizProcesses["+ i +"].BizProcessName");

				data_bizProcesses.Add(bizProcessesItem);
			}
			data.BizProcesses = data_bizProcesses;
			getRemindResponse.Data = data;
        
			return getRemindResponse;
        }
    }
}
