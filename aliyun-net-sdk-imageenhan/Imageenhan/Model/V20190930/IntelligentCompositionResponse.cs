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

namespace Aliyun.Acs.imageenhan.Model.V20190930
{
	public class IntelligentCompositionResponse : AcsResponse
	{

		private string requestId;

		private IntelligentComposition_Data data;

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

		public IntelligentComposition_Data Data
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

		public class IntelligentComposition_Data
		{

			private List<IntelligentComposition_Element> elements;

			public List<IntelligentComposition_Element> Elements
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

			public class IntelligentComposition_Element
			{

				private int? minX;

				private int? minY;

				private int? maxX;

				private int? maxY;

				private float? score;

				public int? MinX
				{
					get
					{
						return minX;
					}
					set	
					{
						minX = value;
					}
				}

				public int? MinY
				{
					get
					{
						return minY;
					}
					set	
					{
						minY = value;
					}
				}

				public int? MaxX
				{
					get
					{
						return maxX;
					}
					set	
					{
						maxX = value;
					}
				}

				public int? MaxY
				{
					get
					{
						return maxY;
					}
					set	
					{
						maxY = value;
					}
				}

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}
			}
		}
	}
}
