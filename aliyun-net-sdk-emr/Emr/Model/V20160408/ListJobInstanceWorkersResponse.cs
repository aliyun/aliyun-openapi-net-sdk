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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListJobInstanceWorkersResponse : AcsResponse
	{

		private string requestId;

		private List<ListJobInstanceWorkers_JobInstanceWorkerInfo> jobInstanceWorkers;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<ListJobInstanceWorkers_JobInstanceWorkerInfo> JobInstanceWorkers
		{
			get
			{
				return jobInstanceWorkers;
			}
			set	
			{
				jobInstanceWorkers = value;
			}
		}

		public class ListJobInstanceWorkers_JobInstanceWorkerInfo
		{

			private string applicationId;

			private string instanceInfo;

			private string containerInfo;

			public string ApplicationId
			{
				get
				{
					return applicationId;
				}
				set	
				{
					applicationId = value;
				}
			}

			public string InstanceInfo
			{
				get
				{
					return instanceInfo;
				}
				set	
				{
					instanceInfo = value;
				}
			}

			public string ContainerInfo
			{
				get
				{
					return containerInfo;
				}
				set	
				{
					containerInfo = value;
				}
			}
		}
	}
}
