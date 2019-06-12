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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class DetectImageBodiesResponse : AcsResponse
	{

		private string requestId;

		private string imageUri;

		private List<DetectImageBodies_BodiesItem> bodies;

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

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
			}
		}

		public List<DetectImageBodies_BodiesItem> Bodies
		{
			get
			{
				return bodies;
			}
			set	
			{
				bodies = value;
			}
		}

		public class DetectImageBodies_BodiesItem
		{

			private float? bodyConfidence;

			private DetectImageBodies_BodyBoundary bodyBoundary;

			public float? BodyConfidence
			{
				get
				{
					return bodyConfidence;
				}
				set	
				{
					bodyConfidence = value;
				}
			}

			public DetectImageBodies_BodyBoundary BodyBoundary
			{
				get
				{
					return bodyBoundary;
				}
				set	
				{
					bodyBoundary = value;
				}
			}

			public class DetectImageBodies_BodyBoundary
			{

				private int? left;

				private int? top;

				private int? width;

				private int? height;

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public int? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public int? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}
			}
		}
	}
}
