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

namespace Aliyun.Acs.imageaudit.Model.V20191230
{
	public class ScanTextResponse : AcsResponse
	{

		private string requestId;

		private ScanText_Data data;

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

		public ScanText_Data Data
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

		public class ScanText_Data
		{

			private List<ScanText_Element> elements;

			public List<ScanText_Element> Elements
			{
				get
				{
					return elements;
				}
				set	
				{
					elements = value;
				}
			}

			public class ScanText_Element
			{

				private string taskId;

				private List<ScanText_Result> results;

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public List<ScanText_Result> Results
				{
					get
					{
						return results;
					}
					set	
					{
						results = value;
					}
				}

				public class ScanText_Result
				{

					private string suggestion;

					private float? rate;

					private string label;

					private List<ScanText_Detail> details;

					public string Suggestion
					{
						get
						{
							return suggestion;
						}
						set	
						{
							suggestion = value;
						}
					}

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

					public List<ScanText_Detail> Details
					{
						get
						{
							return details;
						}
						set	
						{
							details = value;
						}
					}

					public class ScanText_Detail
					{

						private string label;

						private List<ScanText_Context> contexts;

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public List<ScanText_Context> Contexts
						{
							get
							{
								return contexts;
							}
							set	
							{
								contexts = value;
							}
						}

						public class ScanText_Context
						{

							private string context;

							public string Context
							{
								get
								{
									return context;
								}
								set	
								{
									context = value;
								}
							}
						}
					}
				}
			}
		}
	}
}
