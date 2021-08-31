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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class UpdateJvmConfigurationResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private UpdateJvmConfiguration_JvmConfiguration jvmConfiguration;

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

		public UpdateJvmConfiguration_JvmConfiguration JvmConfiguration
		{
			get
			{
				return jvmConfiguration;
			}
			set	
			{
				jvmConfiguration = value;
			}
		}

		public class UpdateJvmConfiguration_JvmConfiguration
		{

			private int? maxHeapSize;

			private int? maxPermSize;

			private int? minHeapSize;

			private string options;

			public int? MaxHeapSize
			{
				get
				{
					return maxHeapSize;
				}
				set	
				{
					maxHeapSize = value;
				}
			}

			public int? MaxPermSize
			{
				get
				{
					return maxPermSize;
				}
				set	
				{
					maxPermSize = value;
				}
			}

			public int? MinHeapSize
			{
				get
				{
					return minHeapSize;
				}
				set	
				{
					minHeapSize = value;
				}
			}

			public string Options
			{
				get
				{
					return options;
				}
				set	
				{
					options = value;
				}
			}
		}
	}
}
