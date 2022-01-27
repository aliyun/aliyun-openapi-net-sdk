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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class TopTenErrorTimesInstanceResponse : AcsResponse
	{

		private string requestId;

		private TopTenErrorTimesInstance_InstanceErrorRank instanceErrorRank;

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

		public TopTenErrorTimesInstance_InstanceErrorRank InstanceErrorRank
		{
			get
			{
				return instanceErrorRank;
			}
			set	
			{
				instanceErrorRank = value;
			}
		}

		public class TopTenErrorTimesInstance_InstanceErrorRank
		{

			private long? updateTime;

			private List<TopTenErrorTimesInstance_ErrorRankItem> errorRank;

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public List<TopTenErrorTimesInstance_ErrorRankItem> ErrorRank
			{
				get
				{
					return errorRank;
				}
				set	
				{
					errorRank = value;
				}
			}

			public class TopTenErrorTimesInstance_ErrorRankItem
			{

				private long? nodeId;

				private string nodeName;

				private string owner;

				private int? count;

				private long? projectId;

				private int? programType;

				public long? NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public int? ProgramType
				{
					get
					{
						return programType;
					}
					set	
					{
						programType = value;
					}
				}
			}
		}
	}
}
