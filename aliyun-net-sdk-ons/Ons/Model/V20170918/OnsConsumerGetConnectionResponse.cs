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

namespace Aliyun.Acs.Ons.Model.V20170918
{
	public class OnsConsumerGetConnectionResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsConsumerGetConnection_Data data;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public OnsConsumerGetConnection_Data Data
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

		public class OnsConsumerGetConnection_Data
		{

			private List<OnsConsumerGetConnection_ConnectionDo> connectionList;

			public List<OnsConsumerGetConnection_ConnectionDo> ConnectionList
			{
				get
				{
					return connectionList;
				}
				set	
				{
					connectionList = value;
				}
			}

			public class OnsConsumerGetConnection_ConnectionDo
			{

				private string clientId;

				private string clientAddr;

				private string language;

				private string version;

				public string ClientId
				{
					get
					{
						return clientId;
					}
					set	
					{
						clientId = value;
					}
				}

				public string ClientAddr
				{
					get
					{
						return clientAddr;
					}
					set	
					{
						clientAddr = value;
					}
				}

				public string Language
				{
					get
					{
						return language;
					}
					set	
					{
						language = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}
			}
		}
	}
}