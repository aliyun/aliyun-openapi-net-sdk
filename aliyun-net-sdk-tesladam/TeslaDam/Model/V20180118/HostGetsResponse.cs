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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaDam.Model.V20180118
{
	public class HostGetsResponse : AcsResponse
	{

		private bool? status;

		private string message;

		private List<HostGets_DataItem> data;

		public bool? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public List<HostGets_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class HostGets_DataItem
		{

			private string hostname;

			private string ip;

			private string appCode;

			private string clusterCode;

			private int? sshStatus;

			private int? heartStatus;

			private int? healthScoreLast;

			private string healthReasonLast;

			public string Hostname
			{
				get
				{
					return hostname;
				}
				set	
				{
					hostname = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string AppCode
			{
				get
				{
					return appCode;
				}
				set	
				{
					appCode = value;
				}
			}

			public string ClusterCode
			{
				get
				{
					return clusterCode;
				}
				set	
				{
					clusterCode = value;
				}
			}

			public int? SshStatus
			{
				get
				{
					return sshStatus;
				}
				set	
				{
					sshStatus = value;
				}
			}

			public int? HeartStatus
			{
				get
				{
					return heartStatus;
				}
				set	
				{
					heartStatus = value;
				}
			}

			public int? HealthScoreLast
			{
				get
				{
					return healthScoreLast;
				}
				set	
				{
					healthScoreLast = value;
				}
			}

			public string HealthReasonLast
			{
				get
				{
					return healthReasonLast;
				}
				set	
				{
					healthReasonLast = value;
				}
			}
		}
	}
}