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

namespace Aliyun.Acs.TeslaStream.Model.V20180115
{
	public class GetJobTopologyResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<GetJobTopology_Job> data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public List<GetJobTopology_Job> Data
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

		public class GetJobTopology_Job
		{

			private string text;

			private string type;

			private string pluginRelation;

			private List<string> parents;

			private List<string> childrens;

			public string Text
			{
				get
				{
					return text;
				}
				set	
				{
					text = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string PluginRelation
			{
				get
				{
					return pluginRelation;
				}
				set	
				{
					pluginRelation = value;
				}
			}

			public List<string> Parents
			{
				get
				{
					return parents;
				}
				set	
				{
					parents = value;
				}
			}

			public List<string> Childrens
			{
				get
				{
					return childrens;
				}
				set	
				{
					childrens = value;
				}
			}
		}
	}
}