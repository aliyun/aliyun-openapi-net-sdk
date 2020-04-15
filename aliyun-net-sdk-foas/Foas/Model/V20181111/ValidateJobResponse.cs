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

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class ValidateJobResponse : AcsResponse
	{

		private string requestId;

		private ValidateJob_JobInOut jobInOut;

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

		public ValidateJob_JobInOut JobInOut
		{
			get
			{
				return jobInOut;
			}
			set	
			{
				jobInOut = value;
			}
		}

		public class ValidateJob_JobInOut
		{

			private List<ValidateJob_Input> inputs;

			private List<ValidateJob_Output> outputs;

			private List<ValidateJob_Dim> dims;

			public List<ValidateJob_Input> Inputs
			{
				get
				{
					return inputs;
				}
				set	
				{
					inputs = value;
				}
			}

			public List<ValidateJob_Output> Outputs
			{
				get
				{
					return outputs;
				}
				set	
				{
					outputs = value;
				}
			}

			public List<ValidateJob_Dim> Dims
			{
				get
				{
					return dims;
				}
				set	
				{
					dims = value;
				}
			}

			public class ValidateJob_Input
			{

				private string type;

				private string workspace;

				private string name;

				private string properties;

				private string alias;

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

				public string Workspace
				{
					get
					{
						return workspace;
					}
					set	
					{
						workspace = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Properties
				{
					get
					{
						return properties;
					}
					set	
					{
						properties = value;
					}
				}

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}
			}

			public class ValidateJob_Output
			{

				private string type;

				private string workspace;

				private string name;

				private string properties;

				private string alias;

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

				public string Workspace
				{
					get
					{
						return workspace;
					}
					set	
					{
						workspace = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Properties
				{
					get
					{
						return properties;
					}
					set	
					{
						properties = value;
					}
				}

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}
			}

			public class ValidateJob_Dim
			{

				private string type;

				private string workspace;

				private string name;

				private string properties;

				private string alias;

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

				public string Workspace
				{
					get
					{
						return workspace;
					}
					set	
					{
						workspace = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Properties
				{
					get
					{
						return properties;
					}
					set	
					{
						properties = value;
					}
				}

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}
			}
		}
	}
}
