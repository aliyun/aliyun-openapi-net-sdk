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
	public class TopTenElapsedTimeInstanceResponse : AcsResponse
	{

		private string requestId;

		private TopTenElapsedTimeInstance_InstanceConsumeTimeRank instanceConsumeTimeRank;

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

		public TopTenElapsedTimeInstance_InstanceConsumeTimeRank InstanceConsumeTimeRank
		{
			get
			{
				return instanceConsumeTimeRank;
			}
			set	
			{
				instanceConsumeTimeRank = value;
			}
		}

		public class TopTenElapsedTimeInstance_InstanceConsumeTimeRank
		{

			private long? updateTime;

			private List<TopTenElapsedTimeInstance_ConsumeTimeRankItem> consumeTimeRank;

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

			public List<TopTenElapsedTimeInstance_ConsumeTimeRankItem> ConsumeTimeRank
			{
				get
				{
					return consumeTimeRank;
				}
				set	
				{
					consumeTimeRank = value;
				}
			}

			public class TopTenElapsedTimeInstance_ConsumeTimeRankItem
			{

				private string owner;

				private string nodeName;

				private long? businessDate;

				private int? programType;

				private long? instanceId;

				private long? nodeId;

				private long? consumed;

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

				public long? BusinessDate
				{
					get
					{
						return businessDate;
					}
					set	
					{
						businessDate = value;
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

				public long? InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

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

				public long? Consumed
				{
					get
					{
						return consumed;
					}
					set	
					{
						consumed = value;
					}
				}
			}
		}
	}
}
