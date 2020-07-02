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
        public static GetRemindResponse Unmarshall(UnmarshallerContext context)
        {
			GetRemindResponse getRemindResponse = new GetRemindResponse();

			getRemindResponse.HttpResponse = context.HttpResponse;
			getRemindResponse.Success = context.BooleanValue("GetRemind.Success");
			getRemindResponse.ErrorCode = context.StringValue("GetRemind.ErrorCode");
			getRemindResponse.ErrorMessage = context.StringValue("GetRemind.ErrorMessage");
			getRemindResponse.HttpStatusCode = context.IntegerValue("GetRemind.HttpStatusCode");
			getRemindResponse.RequestId = context.StringValue("GetRemind.RequestId");

			GetRemindResponse.GetRemind_Data data = new GetRemindResponse.GetRemind_Data();
			data.RemindId = context.LongValue("GetRemind.Data.RemindId");
			data.RemindName = context.StringValue("GetRemind.Data.RemindName");
			data.DndStart = context.StringValue("GetRemind.Data.DndStart");
			data.DndEnd = context.StringValue("GetRemind.Data.DndEnd");
			data.RemindUnit = context.StringValue("GetRemind.Data.RemindUnit");
			data.RemindType = context.StringValue("GetRemind.Data.RemindType");
			data.AlertUnit = context.StringValue("GetRemind.Data.AlertUnit");
			data.Useflag = context.BooleanValue("GetRemind.Data.Useflag");
			data.Founder = context.StringValue("GetRemind.Data.Founder");
			data.AlertInterval = context.IntegerValue("GetRemind.Data.AlertInterval");
			data.Detail = context.StringValue("GetRemind.Data.Detail");
			data.MaxAlertTimes = context.IntegerValue("GetRemind.Data.MaxAlertTimes");

			List<string> data_alertMethods = new List<string>();
			for (int i = 0; i < context.Length("GetRemind.Data.AlertMethods.Length"); i++) {
				data_alertMethods.Add(context.StringValue("GetRemind.Data.AlertMethods["+ i +"]"));
			}
			data.AlertMethods = data_alertMethods;

			List<string> data_alertTargets = new List<string>();
			for (int i = 0; i < context.Length("GetRemind.Data.AlertTargets.Length"); i++) {
				data_alertTargets.Add(context.StringValue("GetRemind.Data.AlertTargets["+ i +"]"));
			}
			data.AlertTargets = data_alertTargets;

			List<GetRemindResponse.GetRemind_Data.GetRemind_RobotsItem> data_robots = new List<GetRemindResponse.GetRemind_Data.GetRemind_RobotsItem>();
			for (int i = 0; i < context.Length("GetRemind.Data.Robots.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_RobotsItem robotsItem = new GetRemindResponse.GetRemind_Data.GetRemind_RobotsItem();
				robotsItem.WebUrl = context.StringValue("GetRemind.Data.Robots["+ i +"].WebUrl");
				robotsItem.AtAll = context.BooleanValue("GetRemind.Data.Robots["+ i +"].AtAll");

				data_robots.Add(robotsItem);
			}
			data.Robots = data_robots;

			List<GetRemindResponse.GetRemind_Data.GetRemind_NodesItem> data_nodes = new List<GetRemindResponse.GetRemind_Data.GetRemind_NodesItem>();
			for (int i = 0; i < context.Length("GetRemind.Data.Nodes.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_NodesItem nodesItem = new GetRemindResponse.GetRemind_Data.GetRemind_NodesItem();
				nodesItem.NodeId = context.LongValue("GetRemind.Data.Nodes["+ i +"].NodeId");
				nodesItem.NodeName = context.StringValue("GetRemind.Data.Nodes["+ i +"].NodeName");
				nodesItem.Owner = context.StringValue("GetRemind.Data.Nodes["+ i +"].Owner");
				nodesItem.ProjectId = context.LongValue("GetRemind.Data.Nodes["+ i +"].ProjectId");

				data_nodes.Add(nodesItem);
			}
			data.Nodes = data_nodes;

			List<GetRemindResponse.GetRemind_Data.GetRemind_BaselinesItem> data_baselines = new List<GetRemindResponse.GetRemind_Data.GetRemind_BaselinesItem>();
			for (int i = 0; i < context.Length("GetRemind.Data.Baselines.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_BaselinesItem baselinesItem = new GetRemindResponse.GetRemind_Data.GetRemind_BaselinesItem();
				baselinesItem.BaselineId = context.LongValue("GetRemind.Data.Baselines["+ i +"].BaselineId");
				baselinesItem.BaselineName = context.StringValue("GetRemind.Data.Baselines["+ i +"].BaselineName");

				data_baselines.Add(baselinesItem);
			}
			data.Baselines = data_baselines;

			List<GetRemindResponse.GetRemind_Data.GetRemind_ProjectsItem> data_projects = new List<GetRemindResponse.GetRemind_Data.GetRemind_ProjectsItem>();
			for (int i = 0; i < context.Length("GetRemind.Data.Projects.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_ProjectsItem projectsItem = new GetRemindResponse.GetRemind_Data.GetRemind_ProjectsItem();
				projectsItem.ProjectId = context.LongValue("GetRemind.Data.Projects["+ i +"].ProjectId");

				data_projects.Add(projectsItem);
			}
			data.Projects = data_projects;

			List<GetRemindResponse.GetRemind_Data.GetRemind_BizProcessesItem> data_bizProcesses = new List<GetRemindResponse.GetRemind_Data.GetRemind_BizProcessesItem>();
			for (int i = 0; i < context.Length("GetRemind.Data.BizProcesses.Length"); i++) {
				GetRemindResponse.GetRemind_Data.GetRemind_BizProcessesItem bizProcessesItem = new GetRemindResponse.GetRemind_Data.GetRemind_BizProcessesItem();
				bizProcessesItem.BizId = context.LongValue("GetRemind.Data.BizProcesses["+ i +"].BizId");
				bizProcessesItem.BizProcessName = context.StringValue("GetRemind.Data.BizProcesses["+ i +"].BizProcessName");

				data_bizProcesses.Add(bizProcessesItem);
			}
			data.BizProcesses = data_bizProcesses;
			getRemindResponse.Data = data;
        
			return getRemindResponse;
        }
    }
}
